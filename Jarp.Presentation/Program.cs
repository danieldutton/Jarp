using Jarp.ProjectMapper;
using Jarp.ProjectMapper.Interfaces;
using System;
using System.Windows.Forms;

namespace Jarp.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IProjectMapper projMapper = new DirReader();

            Application.Run(new Form1(projMapper));
        }
    }
}
