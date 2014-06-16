using Jarp.ProjectMapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarp.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IProjectMapper _projectMapper;

        private string _rootPath;

        private string _destinationPath;


        public Form1(IProjectMapper projectMapper)
        {
            _projectMapper = projectMapper;
            InitializeComponent();
        }

        private void BrowseProject_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            
            DialogResult result = folderBrowser.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                _rootPath = folderBrowser.SelectedPath;
                _txtBoxRoot.Text = _rootPath;
            }
        }

        private void ReadProject_Click(object sender, EventArgs e)
        {
            MapProject();   
        }

        private void MapProject()
        {
            List<string> projectFiles = null;

            Task.Factory.StartNew(() =>
            {
                projectFiles = _projectMapper
                .GetFiles(_rootPath)
                .ToList();
            })
            .ContinueWith(task => _listBoxProject.DataSource = projectFiles);    
        }

        private void OutputDestination_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                _destinationPath = folderBrowser.SelectedPath;
                _txtBoxDestination.Text = _destinationPath;
            }
        }
    }
}
