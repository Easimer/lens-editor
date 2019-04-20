using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace lens_editor
{
    public class CasablancaArchive : IEnumerable<CasablancaArchive.IFile>
    {
        public interface IFile
        {
            UInt64 Hash { get; }
            UInt64 Size { get; }
            bool HasNextVersion { get; }
            UInt64 NextVersion { get; }
            string Path { get; }
        }

        struct CasablancaFile : IFile
        {
            public UInt64 hash, size, offset;
            public byte pmd;
            public UInt64 next_ver;
            public string path;

            public UInt64 Hash { get => hash; }
            public UInt64 Size { get => size; }
            public bool HasNextVersion { get => (pmd & 0x10) != 0; }
            public UInt64 NextVersion { get => next_ver; }
            public string Path { get => path; }
        }

        public CasablancaArchive(string path)
        {
            m_files = new List<CasablancaFile>();
            if(File.Exists(path + ".dir") && File.Exists(path + ".dat"))
            {
                m_directory = new BinaryReader(File.Open(path + ".dir", FileMode.Open));
                m_storage = new BinaryReader(File.Open(path + ".dat", FileMode.Open));
                ParseDirectory();
            }
            else
            {
                throw new FileNotFoundException("The archive doesn't exist!");
            }
        }

        ~CasablancaArchive()
        {
            m_storage?.Close();
            m_directory?.Close();
        }

        void ParseDirectory()
        {
            var magic = m_directory.ReadUInt32();
            var version = magic & 0xF;
            magic &= 0xFFFFFFF0;
            if(magic != 0xCA5AB1A0 || version > 1)
            {
                throw new FormatException("Not a Casablanca archive or it's in a newer format");
            }
            var entries = m_directory.ReadUInt64();

            for(ulong i = 0; i < entries; i++)
            {
                m_files.Add(ReadNext());
            }
        }

        CasablancaFile ReadNext()
        {
            CasablancaFile f = new CasablancaFile();

            f.hash = m_directory.ReadUInt64();
            f.offset = m_directory.ReadUInt64();
            f.size = m_directory.ReadUInt64();
            f.pmd = m_directory.ReadByte();
            m_directory.ReadBytes(7);

            m_storage.BaseStream.Seek((long)f.offset, SeekOrigin.Begin);
            var hdrsiz = m_storage.ReadUInt32();
            var flags = m_storage.ReadUInt32();
            f.next_ver = m_storage.ReadUInt64();
            var path_len = m_storage.ReadUInt64();
            var path_buf = m_storage.ReadBytes((int)path_len);
            f.path = Encoding.ASCII.GetString(path_buf);

            return f;
        }

        BinaryReader m_directory, m_storage;
        List<CasablancaFile> m_files;

        public IEnumerator<IFile> GetEnumerator()
        {
            return m_files.Select(x => x as IFile).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
