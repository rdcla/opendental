//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class QuestionCrud {
		///<summary>Gets one Question object from the database using the primary key.  Returns null if not found.</summary>
		public static Question SelectOne(long questionNum) {
			string command="SELECT * FROM question "
				+"WHERE QuestionNum = "+POut.Long(questionNum);
			List<Question> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Question object from the database using a query.</summary>
		public static Question SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Question> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Question objects from the database using a query.</summary>
		public static List<Question> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Question> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Question> TableToList(DataTable table) {
			List<Question> retVal=new List<Question>();
			Question question;
			foreach(DataRow row in table.Rows) {
				question=new Question();
				question.QuestionNum= PIn.Long  (row["QuestionNum"].ToString());
				question.PatNum     = PIn.Long  (row["PatNum"].ToString());
				question.ItemOrder  = PIn.Int   (row["ItemOrder"].ToString());
				question.Description= PIn.String(row["Description"].ToString());
				question.Answer     = PIn.String(row["Answer"].ToString());
				question.FormPatNum = PIn.Long  (row["FormPatNum"].ToString());
				retVal.Add(question);
			}
			return retVal;
		}

		///<summary>Converts a list of Question into a DataTable.</summary>
		public static DataTable ListToTable(List<Question> listQuestions,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Question";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("QuestionNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("ItemOrder");
			table.Columns.Add("Description");
			table.Columns.Add("Answer");
			table.Columns.Add("FormPatNum");
			foreach(Question question in listQuestions) {
				table.Rows.Add(new object[] {
					POut.Long  (question.QuestionNum),
					POut.Long  (question.PatNum),
					POut.Int   (question.ItemOrder),
					            question.Description,
					            question.Answer,
					POut.Long  (question.FormPatNum),
				});
			}
			return table;
		}

		///<summary>Inserts one Question into the database.  Returns the new priKey.</summary>
		public static long Insert(Question question) {
			return Insert(question,false);
		}

		///<summary>Inserts one Question into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Question question,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				question.QuestionNum=ReplicationServers.GetKey("question","QuestionNum");
			}
			string command="INSERT INTO question (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="QuestionNum,";
			}
			command+="PatNum,ItemOrder,Description,Answer,FormPatNum) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(question.QuestionNum)+",";
			}
			command+=
				     POut.Long  (question.PatNum)+","
				+    POut.Int   (question.ItemOrder)+","
				+    DbHelper.ParamChar+"paramDescription,"
				+    DbHelper.ParamChar+"paramAnswer,"
				+    POut.Long  (question.FormPatNum)+")";
			if(question.Description==null) {
				question.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(question.Description));
			if(question.Answer==null) {
				question.Answer="";
			}
			OdSqlParameter paramAnswer=new OdSqlParameter("paramAnswer",OdDbType.Text,POut.StringParam(question.Answer));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramDescription,paramAnswer);
			}
			else {
				question.QuestionNum=Db.NonQ(command,true,"QuestionNum","question",paramDescription,paramAnswer);
			}
			return question.QuestionNum;
		}

		///<summary>Inserts one Question into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Question question) {
			return InsertNoCache(question,false);
		}

		///<summary>Inserts one Question into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Question question,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO question (";
			if(!useExistingPK && isRandomKeys) {
				question.QuestionNum=ReplicationServers.GetKeyNoCache("question","QuestionNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="QuestionNum,";
			}
			command+="PatNum,ItemOrder,Description,Answer,FormPatNum) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(question.QuestionNum)+",";
			}
			command+=
				     POut.Long  (question.PatNum)+","
				+    POut.Int   (question.ItemOrder)+","
				+    DbHelper.ParamChar+"paramDescription,"
				+    DbHelper.ParamChar+"paramAnswer,"
				+    POut.Long  (question.FormPatNum)+")";
			if(question.Description==null) {
				question.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(question.Description));
			if(question.Answer==null) {
				question.Answer="";
			}
			OdSqlParameter paramAnswer=new OdSqlParameter("paramAnswer",OdDbType.Text,POut.StringParam(question.Answer));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramDescription,paramAnswer);
			}
			else {
				question.QuestionNum=Db.NonQ(command,true,"QuestionNum","question",paramDescription,paramAnswer);
			}
			return question.QuestionNum;
		}

		///<summary>Updates one Question in the database.</summary>
		public static void Update(Question question) {
			string command="UPDATE question SET "
				+"PatNum     =  "+POut.Long  (question.PatNum)+", "
				+"ItemOrder  =  "+POut.Int   (question.ItemOrder)+", "
				+"Description=  "+DbHelper.ParamChar+"paramDescription, "
				+"Answer     =  "+DbHelper.ParamChar+"paramAnswer, "
				+"FormPatNum =  "+POut.Long  (question.FormPatNum)+" "
				+"WHERE QuestionNum = "+POut.Long(question.QuestionNum);
			if(question.Description==null) {
				question.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(question.Description));
			if(question.Answer==null) {
				question.Answer="";
			}
			OdSqlParameter paramAnswer=new OdSqlParameter("paramAnswer",OdDbType.Text,POut.StringParam(question.Answer));
			Db.NonQ(command,paramDescription,paramAnswer);
		}

		///<summary>Updates one Question in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Question question,Question oldQuestion) {
			string command="";
			if(question.PatNum != oldQuestion.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(question.PatNum)+"";
			}
			if(question.ItemOrder != oldQuestion.ItemOrder) {
				if(command!="") { command+=",";}
				command+="ItemOrder = "+POut.Int(question.ItemOrder)+"";
			}
			if(question.Description != oldQuestion.Description) {
				if(command!="") { command+=",";}
				command+="Description = "+DbHelper.ParamChar+"paramDescription";
			}
			if(question.Answer != oldQuestion.Answer) {
				if(command!="") { command+=",";}
				command+="Answer = "+DbHelper.ParamChar+"paramAnswer";
			}
			if(question.FormPatNum != oldQuestion.FormPatNum) {
				if(command!="") { command+=",";}
				command+="FormPatNum = "+POut.Long(question.FormPatNum)+"";
			}
			if(command=="") {
				return false;
			}
			if(question.Description==null) {
				question.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(question.Description));
			if(question.Answer==null) {
				question.Answer="";
			}
			OdSqlParameter paramAnswer=new OdSqlParameter("paramAnswer",OdDbType.Text,POut.StringParam(question.Answer));
			command="UPDATE question SET "+command
				+" WHERE QuestionNum = "+POut.Long(question.QuestionNum);
			Db.NonQ(command,paramDescription,paramAnswer);
			return true;
		}

		///<summary>Returns true if Update(Question,Question) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Question question,Question oldQuestion) {
			if(question.PatNum != oldQuestion.PatNum) {
				return true;
			}
			if(question.ItemOrder != oldQuestion.ItemOrder) {
				return true;
			}
			if(question.Description != oldQuestion.Description) {
				return true;
			}
			if(question.Answer != oldQuestion.Answer) {
				return true;
			}
			if(question.FormPatNum != oldQuestion.FormPatNum) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Question from the database.</summary>
		public static void Delete(long questionNum) {
			string command="DELETE FROM question "
				+"WHERE QuestionNum = "+POut.Long(questionNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Questions from the database.</summary>
		public static void DeleteMany(List<long> listQuestionNums) {
			if(listQuestionNums==null || listQuestionNums.Count==0) {
				return;
			}
			string command="DELETE FROM question "
				+"WHERE QuestionNum IN("+string.Join(",",listQuestionNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}