using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Database.ClassHierarhy;
using Database.Repository;
using System.Reflection;

using UI.Forms.Read;
using UI.Forms.CreateEdit;

namespace UI
{
    public partial class MainWindow : Form
    {
        private UniversityCentre repo;

        private List<string> TypesOfClassHierarhy;

        private ContextMenu contextMenu;

        public MainWindow()
        {
            repo = new UniversityCentre();

            InitializeComponent();

            TypesOfClassHierarhy = repo.GetClassesNames();

            MenuItem details = new MenuItem("Info", OnButtonDetails);
            MenuItem create = new MenuItem("New", OnButtonCreate);
            MenuItem edit = new MenuItem("Edit", OnButtonEdit);
            MenuItem delete = new MenuItem("Delete", OnButtonDelete);
            contextMenu = new ContextMenu(new MenuItem[] { create, edit, delete, details });

            InitializeTree();
        }

        private List<string> GetTypesOfClassHierarhy(string parentType)
        {
            switch(parentType)
            {
                case "University":
                    return TypesOfClassHierarhy;
                case "Person":
                    return TypesOfClassHierarhy;
                case "Student":
                    return TypesOfClassHierarhy;
                case "ForeignStudent":
                    return TypesOfClassHierarhy;
                case "Entrant":
                    return TypesOfClassHierarhy;
                case "Worker":
                    return TypesOfClassHierarhy;
                case "Teacher":
                    return TypesOfClassHierarhy;
                case "root":
                    return TypesOfClassHierarhy;
                default:
                    return null;
            }
        }

        private void InitializeTree()
        {
            foreach(University uobj in repo.GetAllObjectsByMajor(null))
            {
                TreeNode node = tree.Nodes.Add(uobj.Title);
                node.Tag = new NodeInfo { Id = uobj.Id, Expanded = false };

                foreach (University uobj2 in repo.GetAllObjectsByMajor(uobj.Id))
                {
                    TreeNode node2 = node.Nodes.Add(uobj2.Title);
                    node2.Tag = new NodeInfo { Id = uobj2.Id, Expanded = false };
                }
            }
            if(tree.SelectedNode != null)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                if(tree.SelectedNode.Parent == null)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
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
                    foreach (University uobj in repo.GetAllObjectsByMajor(info2.Id))
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
            if (e.Button == MouseButtons.Left)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                if(tree.SelectedNode.Parent == null)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
            }
        }

        #region CRUD

        private void Create(string type, TreeNode parent)
        {
            int id = 0;
            string title = "";
            int? ParentId = parent == null
                ? null
                : (int?)((NodeInfo)parent.Tag).Id;

            switch (type)
            {
                case "University":
                    UniversityCreating uObjWindow = new UniversityCreating();
                    if (uObjWindow.ShowDialog() == DialogResult.OK)
                    {
                        uObjWindow.Value.ParentId = ParentId;
                        repo.CreateUniversity(uObjWindow.Value);
                        id = uObjWindow.Value.Id;
                        title = uObjWindow.Value.Title;
                    }
                    break;
                case "Person":
                    HumanCreating personWindow = new HumanCreating();
                    if (personWindow.ShowDialog() == DialogResult.OK)
                    {
                        personWindow.Value.ParentId = ParentId;
                        repo.CreatePerson(personWindow.Value);
                        id = personWindow.Value.Id;
                        title = personWindow.Value.Title;
                    }
                    break;
                case "Worker":
                    CreateEditWorker workerWindow = new CreateEditWorker();
                    if (workerWindow.ShowDialog() == DialogResult.OK)
                    {
                        workerWindow.Value.ParentId = ParentId;
                        repo.CreateWorker(workerWindow.Value);
                        id = workerWindow.Value.Id;
                        title = workerWindow.Value.Title;
                    }
                    break;
                case "Teacher":
                    CreateEditTeacher teacherWindow = new CreateEditTeacher();
                    if (teacherWindow.ShowDialog() == DialogResult.OK)
                    {
                        teacherWindow.Value.ParentId = ParentId;
                        repo.CreateTeacher(teacherWindow.Value);
                        id = teacherWindow.Value.Id;
                        title = teacherWindow.Value.Title;
                    }
                    break;
                case "Entrant":
                    CreateEditEntrant entrantWindow = new CreateEditEntrant();
                    if (entrantWindow.ShowDialog() == DialogResult.OK)
                    {
                        entrantWindow.Value.ParentId = ParentId;
                        repo.CreateEntrant(entrantWindow.Value);
                        id = entrantWindow.Value.Id;
                        title = entrantWindow.Value.Title;
                    }
                    break;
                case "Student":
                    StudentCreating studentWidnow = new StudentCreating();
                    if (studentWidnow.ShowDialog() == DialogResult.OK)
                    {
                        studentWidnow.Value.ParentId = ParentId;
                        repo.CreateStudent(studentWidnow.Value);
                        id = studentWidnow.Value.Id;
                        title = studentWidnow.Value.Title;
                    }
                    break;
                case "ForeignStudent":
                    CreateEditForeignStudent foreignStudentWindow = new CreateEditForeignStudent();
                    if (foreignStudentWindow.ShowDialog() == DialogResult.OK)
                    {
                        foreignStudentWindow.Value.ParentId = ParentId;
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
            string type = repo.GetUniversityById(id).ClassName;

            ReadUniversity detailsWindow = null;
            switch (type)
            {
                case "University":
                    detailsWindow = new ReadUniversity(repo.GetUniversityById(id));
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
            //    case "University":
            //        ReadUniversity uObjWnd = new ReadUniversity(repo.GetUniversityById(id));
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
            string type = repo.GetUniversityById(id).ClassName;
            switch (type)
            {
                case "University":
                    UniversityCreating uObjWindow = new UniversityCreating(repo.GetUniversityById(id));
                    if (uObjWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateUniversity(uObjWindow.Value);
                        tree.SelectedNode.Text = uObjWindow.Value.Title;
                    }
                    break;
                case "Person":
                    HumanCreating personWindow = new HumanCreating(repo.GetPersonById(id));
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
                    StudentCreating studentWindow = new StudentCreating(repo.GetStudentById(id));
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
            

            string type = repo.GetUniversityById(id).ClassName;

                switch (type)
                {
                    case "University":
                        repo.DeleteUniversity(id);
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
                        StudentCreating studentWindow = new StudentCreating(repo.GetStudentById(id));
                        repo.DeleteStudent(id);
                        break;
                    case "ForeignStudent":
                        repo.DeleteForeignStudent(id);
                        break;
                    default:
                        throw new ArgumentException();
                }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tree.Nodes.Count > 0)
            {
                OnButtonCreate(sender, e);
                return;
            }
            СhooseEntity window = new СhooseEntity(GetTypesOfClassHierarhy("root"));
            if (window.ShowDialog() == DialogResult.OK)
            {
                Create(window.SelectedType, null);
            }
        
        }

        private void OnButtonCreate(object sender, EventArgs e)
        {
            NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
            string type = repo.GetUniversityById(info.Id).ClassName;

            СhooseEntity window = new СhooseEntity(GetTypesOfClassHierarhy(type));

            if (window.ShowDialog() == DialogResult.OK)
            {
                Create(window.SelectedType, tree.SelectedNode);
            }
        }

        private void OnButtonDetails(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
                ShowDetails(info.Id);
            }
        }

        private void OnButtonEdit(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
                Edit(info.Id);
            }
        }

        private void RecurseDel(TreeNode root)
        {
            foreach(TreeNode node in root.Nodes)
            {
                RecurseDel(node);
            }
            Delete(((NodeInfo)root.Tag).Id);
            tree.Nodes.Remove(root);
        }
        private void OnButtonDelete(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete the object?",
                "Delete object", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   RecurseDel(tree.SelectedNode);
                   if (tree.Nodes.Count == 0)
                   {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                   }
                }
            }
        }

        #endregion

        private class NodeInfo
        {
            public int Id { get; set; }
            public bool Expanded { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnButtonEdit(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnButtonDetails(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnButtonDelete(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            СhooseEntity window = new СhooseEntity(GetTypesOfClassHierarhy("root"));
            if (window.ShowDialog() == DialogResult.OK)
            {
                Create(window.SelectedType, null);
            }
        }
    }
}
