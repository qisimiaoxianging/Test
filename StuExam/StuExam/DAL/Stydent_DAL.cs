using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using GZSoft.DBUtility;
using StuExam;
using System.Web;
namespace StuExam.DAL
{

	/// <summary>
	/// 数据访问类:Student
	/// </summary>
	public partial class Student
	{
		public Student()
		{}
		#region  BasicMethod
        
        /// <summary>
        /// 更新密码
        /// </summary>
        public static bool Update(StuExam.Model.Student model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Student set ");
            strSql.Append("Password=@Password");
            strSql.Append(" where StudentId=@StudentId and Name=@Name");
            SqlParameter[] parameters = {
					new SqlParameter("@Password", SqlDbType.NVarChar,20),
                    new SqlParameter("@StudentId", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,15),};
            parameters[0].Value = model.Password;
            parameters[1].Value = model.StudentId;
            parameters[2].Value = model.Name;
            int rows = GZSoft.DBUtility.DbHelper.ExecuteNonQueryBySql(strSql.ToString(), parameters); ;
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static StuExam.Model.Student GetModel(string StudentId,string Password)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 StudentId,Name,Profession,Class,Note from Student ");
            strSql.Append(" where StudentId=@StudentId and Password=@Password");
			SqlParameter[] parameters = {
					new SqlParameter("@StudentId", SqlDbType.NVarChar,20),
                    new SqlParameter("@Password", SqlDbType.NVarChar,20)
                    };
			parameters[0].Value = StudentId;
            parameters[1].Value = Password;
			StuExam.Model.Student model=new StuExam.Model.Student();
            DataSet ds=GZSoft.DBUtility.DbHelper.ExecuteDataSetBySql(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


        /// <summary>
        /// 将DataRow转换为实体
        /// </summary>
        public static StuExam.Model.Student DataRowToModel(DataRow row)
		{
			StuExam.Model.Student model=new StuExam.Model.Student();
			if (row != null)
			{
				if(row["StudentId"]!=null)
				{
					model.StudentId=row["StudentId"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Profession"]!=null)
				{
					model.Profession=row["Profession"].ToString();
				}
				if(row["Class"]!=null)
				{
					model.Class=row["Class"].ToString();
				}
				if(row["Note"]!=null)
				{
					model.Note=row["Note"].ToString();
				}
			}
			return model;
		}
   
		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

	}
 
}
 
