//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class CommlogHistCrud {
		///<summary>Gets one CommlogHist object from the database using the primary key.  Returns null if not found.</summary>
		public static CommlogHist SelectOne(long commlogHistNum) {
			string command="SELECT * FROM commloghist "
				+"WHERE CommlogHistNum = "+POut.Long(commlogHistNum);
			List<CommlogHist> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one CommlogHist object from the database using a query.</summary>
		public static CommlogHist SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<CommlogHist> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of CommlogHist objects from the database using a query.</summary>
		public static List<CommlogHist> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<CommlogHist> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<CommlogHist> TableToList(DataTable table) {
			List<CommlogHist> retVal=new List<CommlogHist>();
			CommlogHist commlogHist;
			foreach(DataRow row in table.Rows) {
				commlogHist=new CommlogHist();
				commlogHist.CommlogHistNum   = PIn.Long  (row["CommlogHistNum"].ToString());
				commlogHist.CustomerNumberRaw= PIn.String(row["CustomerNumberRaw"].ToString());
				commlogHist.HistSource       = (OpenDentBusiness.CommlogHistSource)PIn.Int(row["HistSource"].ToString());
				commlogHist.DateTStamp       = PIn.DateT (row["DateTStamp"].ToString());
				commlogHist.DateTEntry       = PIn.DateT (row["DateTEntry"].ToString());
				commlogHist.CommlogNum       = PIn.Long  (row["CommlogNum"].ToString());
				commlogHist.PatNum           = PIn.Long  (row["PatNum"].ToString());
				commlogHist.CommDateTime     = PIn.DateT (row["CommDateTime"].ToString());
				commlogHist.CommType         = PIn.Long  (row["CommType"].ToString());
				commlogHist.Note             = PIn.String(row["Note"].ToString());
				commlogHist.Mode_            = (OpenDentBusiness.CommItemMode)PIn.Int(row["Mode_"].ToString());
				commlogHist.SentOrReceived   = (OpenDentBusiness.CommSentOrReceived)PIn.Int(row["SentOrReceived"].ToString());
				commlogHist.UserNum          = PIn.Long  (row["UserNum"].ToString());
				commlogHist.Signature        = PIn.String(row["Signature"].ToString());
				commlogHist.SigIsTopaz       = PIn.Bool  (row["SigIsTopaz"].ToString());
				commlogHist.DateTimeEnd      = PIn.DateT (row["DateTimeEnd"].ToString());
				commlogHist.CommSource       = (OpenDentBusiness.CommItemSource)PIn.Int(row["CommSource"].ToString());
				commlogHist.ProgramNum       = PIn.Long  (row["ProgramNum"].ToString());
				retVal.Add(commlogHist);
			}
			return retVal;
		}

		///<summary>Converts a list of CommlogHist into a DataTable.</summary>
		public static DataTable ListToTable(List<CommlogHist> listCommlogHists,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="CommlogHist";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("CommlogHistNum");
			table.Columns.Add("CustomerNumberRaw");
			table.Columns.Add("HistSource");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("DateTEntry");
			table.Columns.Add("CommlogNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("CommDateTime");
			table.Columns.Add("CommType");
			table.Columns.Add("Note");
			table.Columns.Add("Mode_");
			table.Columns.Add("SentOrReceived");
			table.Columns.Add("UserNum");
			table.Columns.Add("Signature");
			table.Columns.Add("SigIsTopaz");
			table.Columns.Add("DateTimeEnd");
			table.Columns.Add("CommSource");
			table.Columns.Add("ProgramNum");
			foreach(CommlogHist commlogHist in listCommlogHists) {
				table.Rows.Add(new object[] {
					POut.Long  (commlogHist.CommlogHistNum),
					            commlogHist.CustomerNumberRaw,
					POut.Int   ((int)commlogHist.HistSource),
					POut.DateT (commlogHist.DateTStamp,false),
					POut.DateT (commlogHist.DateTEntry,false),
					POut.Long  (commlogHist.CommlogNum),
					POut.Long  (commlogHist.PatNum),
					POut.DateT (commlogHist.CommDateTime,false),
					POut.Long  (commlogHist.CommType),
					            commlogHist.Note,
					POut.Int   ((int)commlogHist.Mode_),
					POut.Int   ((int)commlogHist.SentOrReceived),
					POut.Long  (commlogHist.UserNum),
					            commlogHist.Signature,
					POut.Bool  (commlogHist.SigIsTopaz),
					POut.DateT (commlogHist.DateTimeEnd,false),
					POut.Int   ((int)commlogHist.CommSource),
					POut.Long  (commlogHist.ProgramNum),
				});
			}
			return table;
		}

		///<summary>Inserts one CommlogHist into the database.  Returns the new priKey.</summary>
		public static long Insert(CommlogHist commlogHist) {
			return Insert(commlogHist,false);
		}

		///<summary>Inserts one CommlogHist into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(CommlogHist commlogHist,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				commlogHist.CommlogHistNum=ReplicationServers.GetKey("commloghist","CommlogHistNum");
			}
			string command="INSERT INTO commloghist (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="CommlogHistNum,";
			}
			command+="CustomerNumberRaw,HistSource,DateTEntry,CommlogNum,PatNum,CommDateTime,CommType,Note,Mode_,SentOrReceived,UserNum,Signature,SigIsTopaz,DateTimeEnd,CommSource,ProgramNum) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(commlogHist.CommlogHistNum)+",";
			}
			command+=
				 "'"+POut.String(commlogHist.CustomerNumberRaw)+"',"
				+    POut.Int   ((int)commlogHist.HistSource)+","
				//DateTStamp can only be set by MySQL
				+    DbHelper.Now()+","
				+    POut.Long  (commlogHist.CommlogNum)+","
				+    POut.Long  (commlogHist.PatNum)+","
				+    POut.DateT (commlogHist.CommDateTime)+","
				+    POut.Long  (commlogHist.CommType)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    POut.Int   ((int)commlogHist.Mode_)+","
				+    POut.Int   ((int)commlogHist.SentOrReceived)+","
				+    POut.Long  (commlogHist.UserNum)+","
				+    DbHelper.ParamChar+"paramSignature,"
				+    POut.Bool  (commlogHist.SigIsTopaz)+","
				+    POut.DateT (commlogHist.DateTimeEnd)+","
				+    POut.Int   ((int)commlogHist.CommSource)+","
				+    POut.Long  (commlogHist.ProgramNum)+")";
			if(commlogHist.Note==null) {
				commlogHist.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(commlogHist.Note));
			if(commlogHist.Signature==null) {
				commlogHist.Signature="";
			}
			OdSqlParameter paramSignature=new OdSqlParameter("paramSignature",OdDbType.Text,POut.StringParam(commlogHist.Signature));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramNote,paramSignature);
			}
			else {
				commlogHist.CommlogHistNum=Db.NonQ(command,true,"CommlogHistNum","commlogHist",paramNote,paramSignature);
			}
			return commlogHist.CommlogHistNum;
		}

		///<summary>Inserts one CommlogHist into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(CommlogHist commlogHist) {
			return InsertNoCache(commlogHist,false);
		}

		///<summary>Inserts one CommlogHist into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(CommlogHist commlogHist,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO commloghist (";
			if(!useExistingPK && isRandomKeys) {
				commlogHist.CommlogHistNum=ReplicationServers.GetKeyNoCache("commloghist","CommlogHistNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="CommlogHistNum,";
			}
			command+="CustomerNumberRaw,HistSource,DateTEntry,CommlogNum,PatNum,CommDateTime,CommType,Note,Mode_,SentOrReceived,UserNum,Signature,SigIsTopaz,DateTimeEnd,CommSource,ProgramNum) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(commlogHist.CommlogHistNum)+",";
			}
			command+=
				 "'"+POut.String(commlogHist.CustomerNumberRaw)+"',"
				+    POut.Int   ((int)commlogHist.HistSource)+","
				//DateTStamp can only be set by MySQL
				+    DbHelper.Now()+","
				+    POut.Long  (commlogHist.CommlogNum)+","
				+    POut.Long  (commlogHist.PatNum)+","
				+    POut.DateT (commlogHist.CommDateTime)+","
				+    POut.Long  (commlogHist.CommType)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    POut.Int   ((int)commlogHist.Mode_)+","
				+    POut.Int   ((int)commlogHist.SentOrReceived)+","
				+    POut.Long  (commlogHist.UserNum)+","
				+    DbHelper.ParamChar+"paramSignature,"
				+    POut.Bool  (commlogHist.SigIsTopaz)+","
				+    POut.DateT (commlogHist.DateTimeEnd)+","
				+    POut.Int   ((int)commlogHist.CommSource)+","
				+    POut.Long  (commlogHist.ProgramNum)+")";
			if(commlogHist.Note==null) {
				commlogHist.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(commlogHist.Note));
			if(commlogHist.Signature==null) {
				commlogHist.Signature="";
			}
			OdSqlParameter paramSignature=new OdSqlParameter("paramSignature",OdDbType.Text,POut.StringParam(commlogHist.Signature));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramNote,paramSignature);
			}
			else {
				commlogHist.CommlogHistNum=Db.NonQ(command,true,"CommlogHistNum","commlogHist",paramNote,paramSignature);
			}
			return commlogHist.CommlogHistNum;
		}

		///<summary>Updates one CommlogHist in the database.</summary>
		public static void Update(CommlogHist commlogHist) {
			string command="UPDATE commloghist SET "
				+"CustomerNumberRaw= '"+POut.String(commlogHist.CustomerNumberRaw)+"', "
				+"HistSource       =  "+POut.Int   ((int)commlogHist.HistSource)+", "
				//DateTStamp can only be set by MySQL
				//DateTEntry not allowed to change
				+"CommlogNum       =  "+POut.Long  (commlogHist.CommlogNum)+", "
				+"PatNum           =  "+POut.Long  (commlogHist.PatNum)+", "
				+"CommDateTime     =  "+POut.DateT (commlogHist.CommDateTime)+", "
				+"CommType         =  "+POut.Long  (commlogHist.CommType)+", "
				+"Note             =  "+DbHelper.ParamChar+"paramNote, "
				+"Mode_            =  "+POut.Int   ((int)commlogHist.Mode_)+", "
				+"SentOrReceived   =  "+POut.Int   ((int)commlogHist.SentOrReceived)+", "
				+"UserNum          =  "+POut.Long  (commlogHist.UserNum)+", "
				+"Signature        =  "+DbHelper.ParamChar+"paramSignature, "
				+"SigIsTopaz       =  "+POut.Bool  (commlogHist.SigIsTopaz)+", "
				+"DateTimeEnd      =  "+POut.DateT (commlogHist.DateTimeEnd)+", "
				+"CommSource       =  "+POut.Int   ((int)commlogHist.CommSource)+", "
				+"ProgramNum       =  "+POut.Long  (commlogHist.ProgramNum)+" "
				+"WHERE CommlogHistNum = "+POut.Long(commlogHist.CommlogHistNum);
			if(commlogHist.Note==null) {
				commlogHist.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(commlogHist.Note));
			if(commlogHist.Signature==null) {
				commlogHist.Signature="";
			}
			OdSqlParameter paramSignature=new OdSqlParameter("paramSignature",OdDbType.Text,POut.StringParam(commlogHist.Signature));
			Db.NonQ(command,paramNote,paramSignature);
		}

		///<summary>Updates one CommlogHist in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(CommlogHist commlogHist,CommlogHist oldCommlogHist) {
			string command="";
			if(commlogHist.CustomerNumberRaw != oldCommlogHist.CustomerNumberRaw) {
				if(command!="") { command+=",";}
				command+="CustomerNumberRaw = '"+POut.String(commlogHist.CustomerNumberRaw)+"'";
			}
			if(commlogHist.HistSource != oldCommlogHist.HistSource) {
				if(command!="") { command+=",";}
				command+="HistSource = "+POut.Int   ((int)commlogHist.HistSource)+"";
			}
			//DateTStamp can only be set by MySQL
			//DateTEntry not allowed to change
			if(commlogHist.CommlogNum != oldCommlogHist.CommlogNum) {
				if(command!="") { command+=",";}
				command+="CommlogNum = "+POut.Long(commlogHist.CommlogNum)+"";
			}
			if(commlogHist.PatNum != oldCommlogHist.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(commlogHist.PatNum)+"";
			}
			if(commlogHist.CommDateTime != oldCommlogHist.CommDateTime) {
				if(command!="") { command+=",";}
				command+="CommDateTime = "+POut.DateT(commlogHist.CommDateTime)+"";
			}
			if(commlogHist.CommType != oldCommlogHist.CommType) {
				if(command!="") { command+=",";}
				command+="CommType = "+POut.Long(commlogHist.CommType)+"";
			}
			if(commlogHist.Note != oldCommlogHist.Note) {
				if(command!="") { command+=",";}
				command+="Note = "+DbHelper.ParamChar+"paramNote";
			}
			if(commlogHist.Mode_ != oldCommlogHist.Mode_) {
				if(command!="") { command+=",";}
				command+="Mode_ = "+POut.Int   ((int)commlogHist.Mode_)+"";
			}
			if(commlogHist.SentOrReceived != oldCommlogHist.SentOrReceived) {
				if(command!="") { command+=",";}
				command+="SentOrReceived = "+POut.Int   ((int)commlogHist.SentOrReceived)+"";
			}
			if(commlogHist.UserNum != oldCommlogHist.UserNum) {
				if(command!="") { command+=",";}
				command+="UserNum = "+POut.Long(commlogHist.UserNum)+"";
			}
			if(commlogHist.Signature != oldCommlogHist.Signature) {
				if(command!="") { command+=",";}
				command+="Signature = "+DbHelper.ParamChar+"paramSignature";
			}
			if(commlogHist.SigIsTopaz != oldCommlogHist.SigIsTopaz) {
				if(command!="") { command+=",";}
				command+="SigIsTopaz = "+POut.Bool(commlogHist.SigIsTopaz)+"";
			}
			if(commlogHist.DateTimeEnd != oldCommlogHist.DateTimeEnd) {
				if(command!="") { command+=",";}
				command+="DateTimeEnd = "+POut.DateT(commlogHist.DateTimeEnd)+"";
			}
			if(commlogHist.CommSource != oldCommlogHist.CommSource) {
				if(command!="") { command+=",";}
				command+="CommSource = "+POut.Int   ((int)commlogHist.CommSource)+"";
			}
			if(commlogHist.ProgramNum != oldCommlogHist.ProgramNum) {
				if(command!="") { command+=",";}
				command+="ProgramNum = "+POut.Long(commlogHist.ProgramNum)+"";
			}
			if(command=="") {
				return false;
			}
			if(commlogHist.Note==null) {
				commlogHist.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(commlogHist.Note));
			if(commlogHist.Signature==null) {
				commlogHist.Signature="";
			}
			OdSqlParameter paramSignature=new OdSqlParameter("paramSignature",OdDbType.Text,POut.StringParam(commlogHist.Signature));
			command="UPDATE commloghist SET "+command
				+" WHERE CommlogHistNum = "+POut.Long(commlogHist.CommlogHistNum);
			Db.NonQ(command,paramNote,paramSignature);
			return true;
		}

		///<summary>Returns true if Update(CommlogHist,CommlogHist) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(CommlogHist commlogHist,CommlogHist oldCommlogHist) {
			if(commlogHist.CustomerNumberRaw != oldCommlogHist.CustomerNumberRaw) {
				return true;
			}
			if(commlogHist.HistSource != oldCommlogHist.HistSource) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			//DateTEntry not allowed to change
			if(commlogHist.CommlogNum != oldCommlogHist.CommlogNum) {
				return true;
			}
			if(commlogHist.PatNum != oldCommlogHist.PatNum) {
				return true;
			}
			if(commlogHist.CommDateTime != oldCommlogHist.CommDateTime) {
				return true;
			}
			if(commlogHist.CommType != oldCommlogHist.CommType) {
				return true;
			}
			if(commlogHist.Note != oldCommlogHist.Note) {
				return true;
			}
			if(commlogHist.Mode_ != oldCommlogHist.Mode_) {
				return true;
			}
			if(commlogHist.SentOrReceived != oldCommlogHist.SentOrReceived) {
				return true;
			}
			if(commlogHist.UserNum != oldCommlogHist.UserNum) {
				return true;
			}
			if(commlogHist.Signature != oldCommlogHist.Signature) {
				return true;
			}
			if(commlogHist.SigIsTopaz != oldCommlogHist.SigIsTopaz) {
				return true;
			}
			if(commlogHist.DateTimeEnd != oldCommlogHist.DateTimeEnd) {
				return true;
			}
			if(commlogHist.CommSource != oldCommlogHist.CommSource) {
				return true;
			}
			if(commlogHist.ProgramNum != oldCommlogHist.ProgramNum) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one CommlogHist from the database.</summary>
		public static void Delete(long commlogHistNum) {
			string command="DELETE FROM commloghist "
				+"WHERE CommlogHistNum = "+POut.Long(commlogHistNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many CommlogHists from the database.</summary>
		public static void DeleteMany(List<long> listCommlogHistNums) {
			if(listCommlogHistNums==null || listCommlogHistNums.Count==0) {
				return;
			}
			string command="DELETE FROM commloghist "
				+"WHERE CommlogHistNum IN("+string.Join(",",listCommlogHistNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}