//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class AllergyDefCrud {
		///<summary>Gets one AllergyDef object from the database using the primary key.  Returns null if not found.</summary>
		public static AllergyDef SelectOne(long allergyDefNum) {
			string command="SELECT * FROM allergydef "
				+"WHERE AllergyDefNum = "+POut.Long(allergyDefNum);
			List<AllergyDef> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one AllergyDef object from the database using a query.</summary>
		public static AllergyDef SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<AllergyDef> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of AllergyDef objects from the database using a query.</summary>
		public static List<AllergyDef> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<AllergyDef> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<AllergyDef> TableToList(DataTable table) {
			List<AllergyDef> retVal=new List<AllergyDef>();
			AllergyDef allergyDef;
			foreach(DataRow row in table.Rows) {
				allergyDef=new AllergyDef();
				allergyDef.AllergyDefNum= PIn.Long  (row["AllergyDefNum"].ToString());
				allergyDef.Description  = PIn.String(row["Description"].ToString());
				allergyDef.IsHidden     = PIn.Bool  (row["IsHidden"].ToString());
				allergyDef.DateTStamp   = PIn.DateT (row["DateTStamp"].ToString());
				allergyDef.SnomedType   = (OpenDentBusiness.SnomedAllergy)PIn.Int(row["SnomedType"].ToString());
				allergyDef.MedicationNum= PIn.Long  (row["MedicationNum"].ToString());
				allergyDef.UniiCode     = PIn.String(row["UniiCode"].ToString());
				retVal.Add(allergyDef);
			}
			return retVal;
		}

		///<summary>Converts a list of AllergyDef into a DataTable.</summary>
		public static DataTable ListToTable(List<AllergyDef> listAllergyDefs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="AllergyDef";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("AllergyDefNum");
			table.Columns.Add("Description");
			table.Columns.Add("IsHidden");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("SnomedType");
			table.Columns.Add("MedicationNum");
			table.Columns.Add("UniiCode");
			foreach(AllergyDef allergyDef in listAllergyDefs) {
				table.Rows.Add(new object[] {
					POut.Long  (allergyDef.AllergyDefNum),
					            allergyDef.Description,
					POut.Bool  (allergyDef.IsHidden),
					POut.DateT (allergyDef.DateTStamp,false),
					POut.Int   ((int)allergyDef.SnomedType),
					POut.Long  (allergyDef.MedicationNum),
					            allergyDef.UniiCode,
				});
			}
			return table;
		}

		///<summary>Inserts one AllergyDef into the database.  Returns the new priKey.</summary>
		public static long Insert(AllergyDef allergyDef) {
			return Insert(allergyDef,false);
		}

		///<summary>Inserts one AllergyDef into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(AllergyDef allergyDef,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				allergyDef.AllergyDefNum=ReplicationServers.GetKey("allergydef","AllergyDefNum");
			}
			string command="INSERT INTO allergydef (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="AllergyDefNum,";
			}
			command+="Description,IsHidden,SnomedType,MedicationNum,UniiCode) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(allergyDef.AllergyDefNum)+",";
			}
			command+=
				 "'"+POut.String(allergyDef.Description)+"',"
				+    POut.Bool  (allergyDef.IsHidden)+","
				//DateTStamp can only be set by MySQL
				+    POut.Int   ((int)allergyDef.SnomedType)+","
				+    POut.Long  (allergyDef.MedicationNum)+","
				+"'"+POut.String(allergyDef.UniiCode)+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				allergyDef.AllergyDefNum=Db.NonQ(command,true,"AllergyDefNum","allergyDef");
			}
			return allergyDef.AllergyDefNum;
		}

		///<summary>Inserts one AllergyDef into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(AllergyDef allergyDef) {
			return InsertNoCache(allergyDef,false);
		}

		///<summary>Inserts one AllergyDef into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(AllergyDef allergyDef,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO allergydef (";
			if(!useExistingPK && isRandomKeys) {
				allergyDef.AllergyDefNum=ReplicationServers.GetKeyNoCache("allergydef","AllergyDefNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="AllergyDefNum,";
			}
			command+="Description,IsHidden,SnomedType,MedicationNum,UniiCode) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(allergyDef.AllergyDefNum)+",";
			}
			command+=
				 "'"+POut.String(allergyDef.Description)+"',"
				+    POut.Bool  (allergyDef.IsHidden)+","
				//DateTStamp can only be set by MySQL
				+    POut.Int   ((int)allergyDef.SnomedType)+","
				+    POut.Long  (allergyDef.MedicationNum)+","
				+"'"+POut.String(allergyDef.UniiCode)+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				allergyDef.AllergyDefNum=Db.NonQ(command,true,"AllergyDefNum","allergyDef");
			}
			return allergyDef.AllergyDefNum;
		}

		///<summary>Updates one AllergyDef in the database.</summary>
		public static void Update(AllergyDef allergyDef) {
			string command="UPDATE allergydef SET "
				+"Description  = '"+POut.String(allergyDef.Description)+"', "
				+"IsHidden     =  "+POut.Bool  (allergyDef.IsHidden)+", "
				//DateTStamp can only be set by MySQL
				+"SnomedType   =  "+POut.Int   ((int)allergyDef.SnomedType)+", "
				+"MedicationNum=  "+POut.Long  (allergyDef.MedicationNum)+", "
				+"UniiCode     = '"+POut.String(allergyDef.UniiCode)+"' "
				+"WHERE AllergyDefNum = "+POut.Long(allergyDef.AllergyDefNum);
			Db.NonQ(command);
		}

		///<summary>Updates one AllergyDef in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(AllergyDef allergyDef,AllergyDef oldAllergyDef) {
			string command="";
			if(allergyDef.Description != oldAllergyDef.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(allergyDef.Description)+"'";
			}
			if(allergyDef.IsHidden != oldAllergyDef.IsHidden) {
				if(command!="") { command+=",";}
				command+="IsHidden = "+POut.Bool(allergyDef.IsHidden)+"";
			}
			//DateTStamp can only be set by MySQL
			if(allergyDef.SnomedType != oldAllergyDef.SnomedType) {
				if(command!="") { command+=",";}
				command+="SnomedType = "+POut.Int   ((int)allergyDef.SnomedType)+"";
			}
			if(allergyDef.MedicationNum != oldAllergyDef.MedicationNum) {
				if(command!="") { command+=",";}
				command+="MedicationNum = "+POut.Long(allergyDef.MedicationNum)+"";
			}
			if(allergyDef.UniiCode != oldAllergyDef.UniiCode) {
				if(command!="") { command+=",";}
				command+="UniiCode = '"+POut.String(allergyDef.UniiCode)+"'";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE allergydef SET "+command
				+" WHERE AllergyDefNum = "+POut.Long(allergyDef.AllergyDefNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(AllergyDef,AllergyDef) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(AllergyDef allergyDef,AllergyDef oldAllergyDef) {
			if(allergyDef.Description != oldAllergyDef.Description) {
				return true;
			}
			if(allergyDef.IsHidden != oldAllergyDef.IsHidden) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			if(allergyDef.SnomedType != oldAllergyDef.SnomedType) {
				return true;
			}
			if(allergyDef.MedicationNum != oldAllergyDef.MedicationNum) {
				return true;
			}
			if(allergyDef.UniiCode != oldAllergyDef.UniiCode) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one AllergyDef from the database.</summary>
		public static void Delete(long allergyDefNum) {
			string command="DELETE FROM allergydef "
				+"WHERE AllergyDefNum = "+POut.Long(allergyDefNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many AllergyDefs from the database.</summary>
		public static void DeleteMany(List<long> listAllergyDefNums) {
			if(listAllergyDefNums==null || listAllergyDefNums.Count==0) {
				return;
			}
			string command="DELETE FROM allergydef "
				+"WHERE AllergyDefNum IN("+string.Join(",",listAllergyDefNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}