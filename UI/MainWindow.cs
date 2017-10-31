using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Database.Entities;
using Database.Repository;
using System.Reflection;

using UI.Forms.Read;
using UI.Forms.CreateEdit;

namespace UI
{
    public partial class MainWindow : Form
    {
        private URepository repo;

        private List<string> TypesOfEntities;

        private ContextMenu contextMenu;

        public MainWindow()
        {
            repo = new URepository();

            InitializeComponent();

            TypesOfEntities = repo.GetClassesNames();

            MenuItem details = new MenuItem("Details", btnDetails_Click);
            MenuItem create = new MenuItem("Create", btnCreate_Click);
            MenuItem edit = new MenuItem("Edit", btnEdit_Click);
            MenuItem delete = new MenuItem("Delete", btnDelete_Click);
            contextMenu = new ContextMenu(new MenuItem[] { create, details, edit, delete });

            InitializeTree();
        }

        private List<string> GetTypesOfEntities(string parentType)
        {
            switch(parentType)
            {
                case "UObject":
                    return TypesOfEntities;
                case "Person":
                    return TypesOfEntities;
                case "Student":
                    return TypesOfEntities;
                case "ForeignStudent":
                    return TypesOfEntities;
                case "Entrant":
                    return TypesOfEntities;
                case "Worker":
                    return TypesOfEntities;
                case "Teacher":
                    return TypesOfEntities;
                case "root":
                    return TypesOfEntities;
                default:
                    return null;
            }
        }

        private void InitializeTree()
        {
            foreach(UObject uobj in repo.GetAllObjectsByMajor(null))
            {
                TreeNode node = tree.Nodes.Add(uobj.Title);
                node.Tag = new NodeInfo { Id = uobj.Id, Expanded = false };

                foreach (UObject uobj2 in repo.GetAllObjectsByMajor(uobj.Id))
                {
                    TreeNode node2 = node.Nodes.Add(uobj2.Title);
                    node2.Tag = new NodeInfo { Id = uobj2.Id, Expanded = false };
                }
            }
        }

        private void tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeInfo info = (NodeInfo)e.Node.Tag;
            if (!info.Expanded)
            {
                foreach (TreeNode node2 in e.Node.Nodes)
                {
                    NodeInfo info2 = (NodeInfo)node2.Tag;
                    foreach (UObject uobj in repo.GetAllObjectsByMajor(info2.Id))
                    {
                        TreeNode node3 = node2.Nodes.Add(uobj.Title);
                        node3.Tag = new NodeInfo { Id = uobj.Id, Expanded = false };
                    }
                }

                info.Expanded = true;
            }
        }

        private void tree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
        }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right && tree.SelectedNode != null)
            {
                contextMenu.Show(tree, e.Location);
            }
        }

        #region CRUD

        private void Create(string type, TreeNode parent)
        {
            int id = 0;
            string title = "";
            int? majorId = parent == null
                ? null
                : (int?)((NodeInfo)parent.Tag).Id;

            switch (type)
            {
                case "UObject":
                    CreateEditUObject uObjWindow = new CreateEditUObject();
                    if (uObjWindow.ShowDialog() == DialogResult.OK)
                    {
                        uObjWindow.Value.MajorId = majorId;
                        repo.CreateUObject(uObjWindow.Value);
                        id = uObjWindow.Value.Id;
                        title = uObjWindow.Value.Title;
                    }
                    break;
                case "Person":
                    CreateEditPerson personWindow = new CreateEditPerson();
                    if (personWindow.ShowDialog() == DialogResult.OK)
                    {
                        personWindow.Value.MajorId = majorId;
                        repo.CreatePerson(personWindow.Value);
                        id = personWindow.Value.Id;
                        title = personWindow.Value.Title;
                    }
                    break;
                case "Worker":
                    CreateEditWorker workerWindow = new CreateEditWorker();
                    if (workerWindow.ShowDialog() == DialogResult.OK)
                    {
                        workerWindow.Value.MajorId = majorId;
                        repo.CreateWorker(workerWindow.Value);
                        id = workerWindow.Value.Id;
                        title = workerWindow.Value.Title;
                    }
                    break;
                case "Teacher":
                    CreateEditTeacher teacherWindow = new CreateEditTeacher();
                    if (teacherWindow.ShowDialog() == DialogResult.OK)
                    {
                        teacherWindow.Value.MajorId = majorId;
                        repo.CreateTeacher(teacherWindow.Value);
                        id = teacherWindow.Value.Id;
                        title = teacherWindow.Value.Title;
                    }
                    break;
                case "Entrant":
                    CreateEditEntrant entrantWindow = new CreateEditEntrant();
                    if (entrantWindow.ShowDialog() == DialogResult.OK)
                    {
                        entrantWindow.Value.MajorId = majorId;
                        repo.CreateEntrant(entrantWindow.Value);
                        id = entrantWindow.Value.Id;
                        title = entrantWindow.Value.Title;
                    }
                    break;
                case "Student":
                    CreateEditStudent studentWidnow = new CreateEditStudent();
                    if (studentWidnow.ShowDialog() == DialogResult.OK)
                    {
                        studentWidnow.Value.MajorId = majorId;
                        repo.CreateStudent(studentWidnow.Value);
                        id = studentWidnow.Value.Id;
                        title = studentWidnow.Value.Title;
                    }
                    break;
                case "ForeignStudent":
                    CreateEditForeignStudent foreignStudentWindow = new CreateEditForeignStudent();
                    if (foreignStudentWindow.ShowDialog() == DialogResult.OK)
                    {
                        foreignStudentWindow.Value.MajorId = majorId;
                        repo.CreateForeignStudent(foreignStudentWindow.Value);
                        id = foreignStudentWindow.Value.Id;
                        title = foreignStudentWindow.Value.Title;
                    }
                    break;
                default:
                    throw new ArgumentException();
            }

            if (id != 0)
            {
                TreeNode current = parent == null
                    ? tree.Nodes.Add(title)
                    : parent.Nodes.Add(title);

                current.Tag = new NodeInfo { Id = id, Expanded = true };
            }
        }

        private void ShowDetails(int id)
        {
            string type = repo.GetUObjectById(id).ClassName;

            ReadUObject detailsWindow = null;
            switch (type)
            {
                case "UObject":
                    detailsWindow = new ReadUObject(repo.GetUObjectById(id));
                    break;
                case "Person":
                    detailsWindow = new ReadPerson(repo.GetPersonById(id));
                    break;
                case "Worker":
                    detailsWindow = new ReadWorker(repo.GetWorkerById(id));
                    break;
                case "Teacher":
                    detailsWindow = new ReadTeacher(repo.GetTeacherById(id));
                    break;
                case "Entrant":
                    detailsWindow = new ReadEntrant(repo.GetEntrantById(id));
                    break;
                case "Student":
                    detailsWindow = new ReadStudent(repo.GetStudentById(id));
                    break;
                case "ForeignStudent":
                    detailsWindow = new ReadForeignStudent(repo.GetForeignStudentById(id));
                    break;
                default:
                    throw new ArgumentException();
            }

            detailsWindow.ShowDialog();
            //switch (type)
            //{
            //    case "UObject":
            //        ReadUObject uObjWnd = new ReadUObject(repo.GetUObjectById(id));
            //        uObjWnd.ShowDialog();
            //        break;
            //    case "Person":
            //        ReadPerson personWnd = new ReadPerson(repo.GetPersonById(id));
            //        personWnd.ShowDialog();
            //        break;
            //    case "Worker":
            //        ReadWorker workerWnd = new ReadWorker(repo.GetWorkerById(id));
            //        workerWnd.ShowDialog();
            //        break;
            //    case "Teacher":
            //        ReadTeacher teacherWnd = new ReadTeacher(repo.GetTeacherById(id));
            //        teacherWnd.ShowDialog();
            //        break;
            //    case "Entrant":
            //        ReadEntrant entrantWnd = new ReadEntrant(repo.GetEntrantById(id));
            //        entrantWnd.ShowDialog();
            //        break;
            //    case "Student":
            //        ReadStudent studentWnd = new ReadStudent(repo.GetStudentById(id));
            //        studentWnd.ShowDialog();
            //        break;
            //    case "ForeignStudent":
            //        ReadForeignStudent fStudentWnd = new ReadForeignStudent(repo.GetForeignStudentById(id));
            //        fStudentWnd.ShowDialog();
            //        break;
            //    default:
            //        throw new ArgumentException();
            //}
        }

        private void Edit(int id)
        {
            string type = repo.GetUObjectById(id).ClassName;
            switch (type)
            {
                case "UObject":
                    CreateEditUObject uObjWindow = new CreateEditUObject(repo.GetUObjectById(id));
                    if (uObjWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateUObject(uObjWindow.Value);
                        tree.SelectedNode.Text = uObjWindow.Value.Title;
                    }
                    break;
                case "Person":
                    CreateEditPerson personWindow = new CreateEditPerson(repo.GetPersonById(id));
                    if (personWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdatePerson(personWindow.Value);
                        tree.SelectedNode.Text = personWindow.Value.Title;
                    }
                    break;
                case "Worker":
                    CreateEditWorker workerWindow = new CreateEditWorker(repo.GetWorkerById(id));
                    if (workerWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateWorker(workerWindow.Value);
                        tree.SelectedNode.Text = workerWindow.Value.Title;
                    }
                    break;
                case "Teacher":
                    CreateEditTeacher teacherWindow = new CreateEditTeacher(repo.GetTeacherById(id));
                    if (teacherWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateTeacher(teacherWindow.Value);
                        tree.SelectedNode.Text = teacherWindow.Value.Title;
                    }
                    break;
                case "Entrant":
                    CreateEditEntrant entrantWindow = new CreateEditEntrant(repo.GetEntrantById(id));
                    if (entrantWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateEntrant(entrantWindow.Value);
                        tree.SelectedNode.Text = entrantWindow.Value.Title;
                    }
                    break;
                case "Student":
                    CreateEditStudent studentWindow = new CreateEditStudent(repo.GetStudentById(id));
                    if (studentWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateStudent(studentWindow.Value);
                        tree.SelectedNode.Text = studentWindow.Value.Title;
                    }
                    break;
                case "ForeignStudent":
                    CreateEditForeignStudent foreignStudentWindow = new CreateEditForeignStudent(repo.GetForeignStudentById(id));
                    if (foreignStudentWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateForeignStudent(foreignStudentWindow.Value);
                        tree.SelectedNode.Text = foreignStudentWindow.Value.Title;
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void Delete(int id)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete the object?", 
                "Delete object", MessageBoxButtons.YesNo);

            string type = repo.GetUObjectById(id).ClassName;
            if (result == DialogResult.Yes)
            {
                switch (type)
                {
                    case "UObject":
                        repo.DeleteUObject(id);
                        break;
                    case "Person":
                        repo.DeletePerson(id);
                        break;
                    case "Worker":
                        repo.DeleteWorker(id);
                        break;
                    case "Teacher":
                        repo.DeleteTeacher(id);
                        break;
                    case "Entrant":
                        repo.DeleteEntrant(id);
                        break;
                    case "Student":
                        CreateEditStudent studentWindow = new CreateEditStudent(repo.GetStudentById(id));
                        repo.DeleteStudent(id);
                        break;
                    case "ForeignStudent":
                        repo.DeleteForeignStudent(id);
                        break;
                    default:
                        throw new ArgumentException();
                }

                tree.SelectedNode.Remove();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            СhooseEntity window = new СhooseEntity(GetTypesOfEntities("root"));
            if (window.ShowDialog() == DialogResult.OK)
            {
                Create(window.SelectedType, null);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            string type = repo.GetUObjectById(info.Id).ClassName;

            СhooseEntity window = new СhooseEntity(GetTypesOfEntities(type));

            if (window.ShowDialog() == DialogResult.OK)
            {
                Create(window.SelectedType, tree.SelectedNode);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            ShowDetails(info.Id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            Edit(info.Id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNodeCollection children = tree.SelectedNode.Nodes;
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            Delete(info.Id);
            foreach (TreeNode node in children)
            {
                tree.Nodes.Add(node);
            }
        }

        #endregion

        private class NodeInfo
        {
            public int Id { get; set; }
            public bool Expanded { get; set; }
        }
    }
}
