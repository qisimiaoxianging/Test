using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Linq;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace StuExam.Model
{

    /// <summary>
    /// Student:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Student
    {
        public Student()
        { }
        #region Model
        private string _studentid;
        private string _name;
        private string _profession;
        private string _class;
        private string _note;
        private string _password;
        /// <summary>
        /// 
        /// </summary>
        public string StudentId
        {
            set { _studentid = value; }
            get { return _studentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Profession
        {
            set { _profession = value; }
            get { return _profession; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Class
        {
            set { _class = value; }
            get { return _class; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            set { _note = value; }
            get { return _note; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        #endregion Model

    }
  


}

