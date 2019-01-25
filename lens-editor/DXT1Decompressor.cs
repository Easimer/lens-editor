using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace lens_editor
{
    public class DXT1Decompressor
    {
        struct Color
        {
            public Color(float r = 0, float g = 0, float b = 0)
            {
                this.r = r; this.g = g; this.b = b;
            }
            float r, g, b;

            // R and B components are swapped
            public byte R
            {
                get => (byte)(b * 255);
            }
            public byte G
            {
                get => (byte)(g * 255);
            }
            public byte B
            {
                get => (byte)(r * 255);
            }
        }
        class Block
        {
            public Color[] pixels = new Color[16];
        }

        Block DecompressBlock(int x, int y, int width, byte[] blob)
        {
            Block ret = new Block();

            int off = (y * width / 4 + x) * (64 / 8);

            UInt16 c0, c1;
            int c0_r, c0_g, c0_b;
            int c1_r, c1_g, c1_b;
            int c2_r, c2_g, c2_b;
            int c3_r, c3_g, c3_b;
            UInt16 c0_lo = blob[off + 0];
            UInt16 c0_hi = blob[off + 1];
            UInt16 c1_lo = blob[off + 2];
            UInt16 c1_hi = blob[off + 3];
            c0 = (UInt16)((c0_hi << 8) | c0_lo);
            c1 = (UInt16)((c1_hi << 8) | c1_lo);

            c0_r = (c0 & 0b1111100000000000) >> 11;
            c0_g = (c0 & 0b0000011111100000) >> 5;
            c0_b = c0 & 0b0000000000011111;
            c1_r = (c1 & 0b1111100000000000) >> 11;
            c1_g = (c1 & 0b0000011111100000) >> 5;
            c1_b = c1 & 0b0000000000011111;

            if(c0 > c1)
            {
                c2_r = (2 * c0_r + c1_r) / 3;
                c2_g = (2 * c0_g + c1_g) / 3;
                c2_b = (2 * c0_b + c1_b) / 3;
                c3_r = (c0_r + 2 * c1_r) / 3;
                c3_g = (c0_g + 2 * c1_g) / 3;
                c3_b = (c0_b + 2 * c1_b) / 3;
            } else
            {
                c2_r = (c0_r + c1_r) / 2;
                c2_g = (c0_g + c1_g) / 2;
                c2_b = (c0_b + c1_b) / 2;
                c3_r = c3_g = c3_b = 0;
            }

            Color[] lookup = new Color[]
            {
                new Color(c0_r / 32.0f, c0_g / 64.0f, c0_b / 32.0f),
                new Color(c1_r / 32.0f, c1_g / 64.0f, c1_b / 32.0f),
                new Color(c2_r / 32.0f, c2_g / 64.0f, c2_b / 32.0f),
                new Color(c3_r / 32.0f, c3_g / 64.0f, c3_b / 32.0f),
            };

            for(int by = 0; by < 4; by++)
            {
                for(int bx = 0; bx < 4; bx++)
                {
                    var code = (blob[off + by] << (bx * 2)) & 3;
                    ret.pixels[by * 4 + bx] = lookup[code];
                }
            }

            return ret;
        }

        public DXT1Decompressor(int width, int height, byte[] blob)
        {

            m_bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var data = m_bitmap.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var ptr = data.Scan0;

            int bytes = Math.Abs(data.Stride) * m_bitmap.Height;
            byte[] rgb_values = new byte[bytes];

            for(int by = 0; by < m_bitmap.Height / 4; by++)
            {
                for(int bx = 0; bx < m_bitmap.Width / 4; bx++)
                {
                    var block = DecompressBlock(bx, by, width, blob);
                    var block_off = by * 4 * m_bitmap.Width * 3 + bx * 4 * 3;
                    var block_addr = by * m_bitmap.Width / 4;
                    for(int py = 0; py < 4; py++)
                    {
                        var line_off = block_off + py * m_bitmap.Width * 3;
                        for(int px = 0; px < 4; px++)
                        {
                            var pix_off = line_off + px * 3;
                            rgb_values[pix_off + 0] = block.pixels[py * 4 + px].R;
                            rgb_values[pix_off + 1] = block.pixels[py * 4 + px].G;
                            rgb_values[pix_off + 2] = block.pixels[py * 4 + px].B;
                        }
                    }
                }
            }
            Marshal.Copy(rgb_values, 0, ptr, bytes);
            m_bitmap.UnlockBits(data);
        }

        private Bitmap m_bitmap;

        public Bitmap Bitmap
        {
            get => m_bitmap;
        }
    }
}
