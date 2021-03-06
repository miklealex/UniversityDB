﻿using System;
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
            foreach(Database.ClassHierarhy.University uobj in repo.GetAllObjectsByMajor(null))
            {
                TreeNode node = tree.Nodes.Add(uobj.Title);
                node.Tag = new NodeInfo { Id = uobj.Id, Expanded = false };

                foreach (Database.ClassHierarhy.University uobj2 in repo.GetAllObjectsByMajor(uobj.Id))
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
                    foreach (Database.ClassHierarhy.University uobj in repo.GetAllObjectsByMajor(info2.Id))
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
                if(tree.SelectedNode != null && tree.SelectedNode.Parent == null)
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
                    WorkerCreating workerWindow = new WorkerCreating();
                    if (workerWindow.ShowDialog() == DialogResult.OK)
                    {
                        workerWindow.Value.ParentId = ParentId;
                        repo.CreateWorker(workerWindow.Value);
                        id = workerWindow.Value.Id;
                        title = workerWindow.Value.Title;
                    }
                    break;
                case "Teacher":
                    TeacherCreating teacherWindow = new TeacherCreating();
                    if (teacherWindow.ShowDialog() == DialogResult.OK)
                    {
                        teacherWindow.Value.ParentId = ParentId;
                        repo.CreateTeacher(teacherWindow.Value);
                        id = teacherWindow.Value.Id;
                        title = teacherWindow.Value.Title;
                    }
                    break;
                case "Entrant":
                    EntrantCreating entrantWindow = new EntrantCreating();
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
                    ForeignStudentCreating foreignStudentWindow = new ForeignStudentCreating();
                    if (foreignStudentWindow.ShowDialog() == DialogResult.OK)
                    {
                        foreignStudentWindow.Value.ParentId = ParentId;
                        repo.CreateForeignStudent(foreignStudentWindow.Value);
                        id = foreignStudentWindow.Value.Id;
                        title = foreignStudentWindow.Value.Title;
                    }
                    break;
                case "Faculty":
                    UI.Forms.CreateEdit.Faculty facult = new Forms.CreateEdit.Faculty(repo);
                    facult.repo = repo;
                    if(facult.ShowDialog() == DialogResult.OK)
                    {
                        facult.Value.ParentId = ParentId;
                        repo.CreateFaculty(facult.Value);
                        foreach (ListViewItem obj in facult.listView1.Items)
                        {
                            Database.ClassHierarhy.Institute currentTeacher = repo.GetInstituteById(int.Parse(obj.Text.Split(' ')[0]));
                            currentTeacher.facultyId = facult.Value.Id;
                            repo.UpdateInstitute(currentTeacher);
                        }
                        id = facult.Value.Id;
                        title = facult.Value.Title;
                    }
                    break;
                case "Institute":
                    UI.Forms.CreateEdit.Institute inst = new Forms.CreateEdit.Institute(repo);
                    
                    if(inst.ShowDialog() == DialogResult.OK)
                    {
                        inst.Value.ParentId = ParentId;
                        repo.CreateInstitute(inst.Value);
                        foreach(ListViewItem obj in inst.listView1.Items)
                        {
                            Database.ClassHierarhy.Teacher currentTeacher = repo.GetTeacherById(int.Parse(obj.Text.Split(' ')[0]));
                            currentTeacher.InstituteId = inst.Value.Id;
                            repo.UpdateTeacher(currentTeacher);
                        }
                        id = inst.Value.Id;
                        title = inst.Value.Title;
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

            UI.Forms.Read.University detailsWindow = null;
            switch (type)
            {
                case "University":
                    detailsWindow = new UI.Forms.Read.University(repo.GetUniversityById(id));
                    break;
                case "Person":
                    detailsWindow = new UI.Forms.Read.Human(repo.GetPersonById(id));
                    break;
                case "Worker":
                    detailsWindow = new UI.Forms.Read.Worker(repo.GetWorkerById(id));
                    break;
                case "Teacher":
                    detailsWindow = new UI.Forms.Read.Teacher(repo.GetTeacherById(id));
                    break;
                case "Entrant":
                    detailsWindow = new UI.Forms.Read.Entrant(repo.GetEntrantById(id));
                    break;
                case "Student":
                    detailsWindow = new UI.Forms.Read.Student(repo.GetStudentById(id));
                    break;
                case "ForeignStudent":
                    detailsWindow = new UI.Forms.Read.ForeignStudent(repo.GetForeignStudentById(id));
                    break;
                case "Faculty":
                    detailsWindow = new UI.Forms.Read.FacultyRead(repo.GetFacultyById(id));
                    break;
                case "Institute":
                    detailsWindow = new UI.Forms.Read.InstituteRead(repo.GetInstituteById(id));
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
                    WorkerCreating workerWindow = new WorkerCreating(repo.GetWorkerById(id));
                    if (workerWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateWorker(workerWindow.Value);
                        tree.SelectedNode.Text = workerWindow.Value.Title;
                    }
                    break;
                case "Teacher":
                    TeacherCreating teacherWindow = new TeacherCreating(repo.GetTeacherById(id));
                    if (teacherWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateTeacher(teacherWindow.Value);
                        tree.SelectedNode.Text = teacherWindow.Value.Title;
                    }
                    break;
                case "Entrant":
                    EntrantCreating entrantWindow = new EntrantCreating(repo.GetEntrantById(id));
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
                    ForeignStudentCreating foreignStudentWindow = new ForeignStudentCreating(repo.GetForeignStudentById(id));
                    if (foreignStudentWindow.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateForeignStudent(foreignStudentWindow.Value);
                        tree.SelectedNode.Text = foreignStudentWindow.Value.Title;
                    }
                    break;
                case "Faculty":
                    UI.Forms.CreateEdit.Faculty facult = new UI.Forms.CreateEdit.Faculty(repo.GetFacultyById(id), repo);
                    if(facult.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateFaculty(facult.Value);
                        tree.SelectedNode.Text = facult.Value.Title;
                    }
                    break;
                case "Institute":
                    UI.Forms.CreateEdit.Institute inst = new UI.Forms.CreateEdit.Institute(repo.GetInstituteById(id), repo);
                    
                    if(inst.ShowDialog() == DialogResult.OK)
                    {
                        repo.UpdateInstitute(inst.Value);
                        tree.SelectedNode.Text = inst.Value.Title;
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
                    case "Faculty":
                        repo.DeleteFaculty(id);
                        break;
                    case "Institute":
                    repo.DeleteInstitute(id);
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
            if (tree.SelectedNode != null)
            {
                NodeInfo info = (NodeInfo)tree.SelectedNode.Tag;
                string type = repo.GetUniversityById(info.Id).ClassName;

                СhooseEntity window = new СhooseEntity(GetTypesOfClassHierarhy(type));

                if (window.ShowDialog() == DialogResult.OK)
                {
                    Create(window.SelectedType, tree.SelectedNode);
                }
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
