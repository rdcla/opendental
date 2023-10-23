//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class ElectIDCrud {
		///<summary>Gets one ElectID object from the database using the primary key.  Returns null if not found.</summary>
		public static ElectID SelectOne(long electIDNum) {
			string command="SELECT * FROM electid "
				+"WHERE ElectIDNum = "+POut.Long(electIDNum);
			List<ElectID> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one ElectID object from the database using a query.</summary>
		public static ElectID SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ElectID> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of ElectID objects from the database using a query.</summary>
		public static List<ElectID> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ElectID> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<ElectID> TableToList(DataTable table) {
			List<ElectID> retVal=new List<ElectID>();
			ElectID electID;
			foreach(DataRow row in table.Rows) {
				electID=new ElectID();
				electID.ElectIDNum   = PIn.Long  (row["ElectIDNum"].ToString());
				electID.PayorID      = PIn.String(row["PayorID"].ToString());
				electID.CarrierName  = PIn.String(row["CarrierName"].ToString());
				electID.IsMedicaid   = PIn.Bool  (row["IsMedicaid"].ToString());
				electID.ProviderTypes= PIn.String(row["ProviderTypes"].ToString());
				electID.Comments     = PIn.String(row["Comments"].ToString());
				electID.CommBridge   = (OpenDentBusiness.EclaimsCommBridge)PIn.Int(row["CommBridge"].ToString());
				electID.Attributes   = PIn.String(row["Attributes"].ToString());
				retVal.Add(electID);
			}
			return retVal;
		}

		///<summary>Converts a list of ElectID into a DataTable.</summary>
		public static DataTable ListToTable(List<ElectID> listElectIDs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="ElectID";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ElectIDNum");
			table.Columns.Add("PayorID");
			table.Columns.Add("CarrierName");
			table.Columns.Add("IsMedicaid");
			table.Columns.Add("ProviderTypes");
			table.Columns.Add("Comments");
			table.Columns.Add("CommBridge");
			table.Columns.Add("Attributes");
			foreach(ElectID electID in listElectIDs) {
				table.Rows.Add(new object[] {
					POut.Long  (electID.ElectIDNum),
					            electID.PayorID,
					            electID.CarrierName,
					POut.Bool  (electID.IsMedicaid),
					            electID.ProviderTypes,
					            electID.Comments,
					POut.Int   ((int)electID.CommBridge),
					            electID.Attributes,
				});
			}
			return table;
		}

		///<summary>Inserts one ElectID into the database.  Returns the new priKey.</summary>
		public static long Insert(ElectID electID) {
			return Insert(electID,false);
		}

		///<summary>Inserts one ElectID into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(ElectID electID,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				electID.ElectIDNum=ReplicationServers.GetKey("electid","ElectIDNum");
			}
			string command="INSERT INTO electid (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ElectIDNum,";
			}
			command+="PayorID,CarrierName,IsMedicaid,ProviderTypes,Comments,CommBridge,Attributes) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(electID.ElectIDNum)+",";
			}
			command+=
				 "'"+POut.String(electID.PayorID)+"',"
				+"'"+POut.String(electID.CarrierName)+"',"
				+    POut.Bool  (electID.IsMedicaid)+","
				+"'"+POut.String(electID.ProviderTypes)+"',"
				+    DbHelper.ParamChar+"paramComments,"
				+    POut.Int   ((int)electID.CommBridge)+","
				+"'"+POut.String(electID.Attributes)+"')";
			if(electID.Comments==null) {
				electID.Comments="";
			}
			OdSqlParameter paramComments=new OdSqlParameter("paramComments",OdDbType.Text,POut.StringParam(electID.Comments));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramComments);
			}
			else {
				electID.ElectIDNum=Db.NonQ(command,true,"ElectIDNum","electID",paramComments);
			}
			return electID.ElectIDNum;
		}

		///<summary>Inserts one ElectID into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ElectID electID) {
			return InsertNoCache(electID,false);
		}

		///<summary>Inserts one ElectID into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ElectID electID,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO electid (";
			if(!useExistingPK && isRandomKeys) {
				electID.ElectIDNum=ReplicationServers.GetKeyNoCache("electid","ElectIDNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ElectIDNum,";
			}
			command+="PayorID,CarrierName,IsMedicaid,ProviderTypes,Comments,CommBridge,Attributes) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(electID.ElectIDNum)+",";
			}
			command+=
				 "'"+POut.String(electID.PayorID)+"',"
				+"'"+POut.String(electID.CarrierName)+"',"
				+    POut.Bool  (electID.IsMedicaid)+","
				+"'"+POut.String(electID.ProviderTypes)+"',"
				+    DbHelper.ParamChar+"paramComments,"
				+    POut.Int   ((int)electID.CommBridge)+","
				+"'"+POut.String(electID.Attributes)+"')";
			if(electID.Comments==null) {
				electID.Comments="";
			}
			OdSqlParameter paramComments=new OdSqlParameter("paramComments",OdDbType.Text,POut.StringParam(electID.Comments));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramComments);
			}
			else {
				electID.ElectIDNum=Db.NonQ(command,true,"ElectIDNum","electID",paramComments);
			}
			return electID.ElectIDNum;
		}

		///<summary>Updates one ElectID in the database.</summary>
		public static void Update(ElectID electID) {
			string command="UPDATE electid SET "
				+"PayorID      = '"+POut.String(electID.PayorID)+"', "
				+"CarrierName  = '"+POut.String(electID.CarrierName)+"', "
				+"IsMedicaid   =  "+POut.Bool  (electID.IsMedicaid)+", "
				+"ProviderTypes= '"+POut.String(electID.ProviderTypes)+"', "
				+"Comments     =  "+DbHelper.ParamChar+"paramComments, "
				+"CommBridge   =  "+POut.Int   ((int)electID.CommBridge)+", "
				+"Attributes   = '"+POut.String(electID.Attributes)+"' "
				+"WHERE ElectIDNum = "+POut.Long(electID.ElectIDNum);
			if(electID.Comments==null) {
				electID.Comments="";
			}
			OdSqlParameter paramComments=new OdSqlParameter("paramComments",OdDbType.Text,POut.StringParam(electID.Comments));
			Db.NonQ(command,paramComments);
		}

		///<summary>Updates one ElectID in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(ElectID electID,ElectID oldElectID) {
			string command="";
			if(electID.PayorID != oldElectID.PayorID) {
				if(command!="") { command+=",";}
				command+="PayorID = '"+POut.String(electID.PayorID)+"'";
			}
			if(electID.CarrierName != oldElectID.CarrierName) {
				if(command!="") { command+=",";}
				command+="CarrierName = '"+POut.String(electID.CarrierName)+"'";
			}
			if(electID.IsMedicaid != oldElectID.IsMedicaid) {
				if(command!="") { command+=",";}
				command+="IsMedicaid = "+POut.Bool(electID.IsMedicaid)+"";
			}
			if(electID.ProviderTypes != oldElectID.ProviderTypes) {
				if(command!="") { command+=",";}
				command+="ProviderTypes = '"+POut.String(electID.ProviderTypes)+"'";
			}
			if(electID.Comments != oldElectID.Comments) {
				if(command!="") { command+=",";}
				command+="Comments = "+DbHelper.ParamChar+"paramComments";
			}
			if(electID.CommBridge != oldElectID.CommBridge) {
				if(command!="") { command+=",";}
				command+="CommBridge = "+POut.Int   ((int)electID.CommBridge)+"";
			}
			if(electID.Attributes != oldElectID.Attributes) {
				if(command!="") { command+=",";}
				command+="Attributes = '"+POut.String(electID.Attributes)+"'";
			}
			if(command=="") {
				return false;
			}
			if(electID.Comments==null) {
				electID.Comments="";
			}
			OdSqlParameter paramComments=new OdSqlParameter("paramComments",OdDbType.Text,POut.StringParam(electID.Comments));
			command="UPDATE electid SET "+command
				+" WHERE ElectIDNum = "+POut.Long(electID.ElectIDNum);
			Db.NonQ(command,paramComments);
			return true;
		}

		///<summary>Returns true if Update(ElectID,ElectID) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(ElectID electID,ElectID oldElectID) {
			if(electID.PayorID != oldElectID.PayorID) {
				return true;
			}
			if(electID.CarrierName != oldElectID.CarrierName) {
				return true;
			}
			if(electID.IsMedicaid != oldElectID.IsMedicaid) {
				return true;
			}
			if(electID.ProviderTypes != oldElectID.ProviderTypes) {
				return true;
			}
			if(electID.Comments != oldElectID.Comments) {
				return true;
			}
			if(electID.CommBridge != oldElectID.CommBridge) {
				return true;
			}
			if(electID.Attributes != oldElectID.Attributes) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one ElectID from the database.</summary>
		public static void Delete(long electIDNum) {
			string command="DELETE FROM electid "
				+"WHERE ElectIDNum = "+POut.Long(electIDNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many ElectIDs from the database.</summary>
		public static void DeleteMany(List<long> listElectIDNums) {
			if(listElectIDNums==null || listElectIDNums.Count==0) {
				return;
			}
			string command="DELETE FROM electid "
				+"WHERE ElectIDNum IN("+string.Join(",",listElectIDNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}