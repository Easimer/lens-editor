using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lens_editor.Controls
{
    public partial class LevelGrid : UserControl
    {
        private struct Rectangle
        {
            public Rectangle(int x, int y, int w, int h)
            {
                this.x = x; this.y = y;
                this.w = w; this.h = h;
            }

            public bool Contains(Point p)
            {
                if(!(p.X >= x && p.X <= x + w))
                {
                    return false;
                }
                if(!(p.Y >= y && p.Y <= y + h))
                {
                    return false;
                }
                return true;
            }
            int x, y, w, h;
        }
        private Pen m_pen_grid_bg;
        private Pen m_pen_grid_fg;
        private Pen m_pen_grid_center;
        private Pen m_pen_grid_ent;

        IEnumerable<Entity> entities;
        public IEnumerable<Entity> Entities {get => entities; set => entities = value;}

        float camera_x, camera_y;
        Point cursor_pos;
        bool cursor_pressed = false;
        float camera_scale;
        Point form_rel_loc = Point.Empty;

        Point grid_block_selected = Point.Empty;

        public LevelGrid()
        {
            InitializeComponent();

            DoubleBuffered = true;

            m_pen_grid_bg = new Pen(Color.Black);
            m_pen_grid_fg = new Pen(Color.LightGoldenrodYellow);
            m_pen_grid_center = new Pen(Color.DarkCyan, 2);
            m_pen_grid_ent = new Pen(Color.Magenta, 1.25f);

            camera_x = camera_y = 0;
            camera_scale = 1;

            BackColor = Color.Black;

            cursor_text_pos = new PointF(Location.X + 4.0f, Location.Y + 32.0f);

            UpdateFormRelativePosition();
        }

        PointF cursor_text_pos;
        static Font font = new Font("Fixedsys", 12);

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            switch(e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            float grid_step = camera_scale * 4;
            if(e.KeyCode == Keys.Left)
            {
                camera_x += grid_step;
            }
            if(e.KeyCode == Keys.Right)
            {
                camera_x -= grid_step;
            }
            if(e.KeyCode == Keys.Up)
            {
                camera_y += grid_step;
            }
            if(e.KeyCode == Keys.Down)
            {
                camera_y -= grid_step;
            }
            Refresh();
        }

        private void UpdateFormRelativePosition()
        {
            form_rel_loc = PointToScreen(Location);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            UpdateFormRelativePosition();
        }

        protected override void OnPaint(PaintEventArgs ev)
        {
            base.OnPaint(ev);
            var g = ev.Graphics;

            float grid_step = camera_scale * 20;

            //g.DrawRectangle(m_pen_grid_bg, ev.ClipRectangle);
            int rem_y = (int)(camera_y % grid_step);
            int rem_x = (int)(camera_x % grid_step);

            int off_x = form_rel_loc.X + rem_x;
            int off_y = form_rel_loc.Y + rem_y;

            for(int y = 0; y < ev.ClipRectangle.Bottom - ev.ClipRectangle.Top; y += (int)grid_step)
            {
                Pen p = m_pen_grid_fg;
                if(y - (int)camera_y == 0)
                {
                    p = m_pen_grid_center;
                }
                g.DrawLine(p, new Point(0, y + off_y), new Point(ev.ClipRectangle.Right, y + off_y));
            }

            for(int x = 0; x < ev.ClipRectangle.Right - ev.ClipRectangle.Left; x += (int)grid_step)
            {
                Pen p = m_pen_grid_fg;
                if(x - (int)camera_x == 0)
                {
                    p = m_pen_grid_center;
                }
                g.DrawLine(p, new Point(x + off_x, 0), new Point(x + off_x, ev.ClipRectangle.Bottom));
            }

            g.DrawString(String.Format("{0},{1}", cursor_pos.X, cursor_pos.Y), font, m_pen_grid_fg.Brush, cursor_text_pos);

            Rectangle WorldRect = new Rectangle((int)camera_x, (int)camera_y, Size.Width, Size.Height);

            if (entities != null)
            {
                foreach (var ent in entities)
                {
                    float[] position = null;
                    foreach (var kv in ent.keyvalues)
                    {
                        if (kv.name == "position")
                        {
                            position = kv.value as float[];
                        }
                    }

                    if (position != null)
                    {
                        var pos = new Point((int)position[0], (int)position[1]);
                        if (WorldRect.Contains(pos))
                        {
                            var x = position[0];
                            var y = position[2];

                            x += camera_x;
                            y += camera_y;
                            x += form_rel_loc.X;
                            y += form_rel_loc.Y;
                            var entrect = new System.Drawing.Rectangle((int)x, (int)y, 16, 16);
                            g.DrawRectangle(m_pen_grid_ent, entrect);
                            //g.DrawString(ent.classname, font, m_pen_grid_ent.Brush, (int)position[0] + 16, (int)position[1]);
                            g.DrawString(ent.classname, font, m_pen_grid_ent.Brush, x, y);
                            if (entrect.Contains(cursor_pos))
                            {
                            }
                        }
                    }
                }
            }
            cursor_pressed = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            //var old_cursor_pos = cursor_pos;
            //cursor_pos = Point.Subtract(e.Location, new Size((int)(camera_x * camera_scale), (int)(camera_y * camera_scale)));

            cursor_pressed = true;

            Refresh();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            var old_cursor_pos = cursor_pos;
            cursor_pos = Point.Subtract(e.Location, new Size((int)(camera_x * camera_scale), (int)(camera_y * camera_scale)));

            if(e.Button.HasFlag(MouseButtons.Right))
            {
                var d = Point.Subtract(cursor_pos, new Size(old_cursor_pos));
                camera_x += d.X;
                camera_y += d.Y;
            }

            Refresh();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            /*
            camera_scale -= (float)e.Delta / 256.0f;
            if(camera_scale < 0.25f)
            {
                camera_scale = 0.25f;
            }
            if(camera_scale > 4)
            {
                camera_scale = 4;
            }
            */
            Refresh();
        }
    }
}
