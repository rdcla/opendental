//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class CDSPermissionCrud {
		///<summary>Gets one CDSPermission object from the database using the primary key.  Returns null if not found.</summary>
		public static CDSPermission SelectOne(long cDSPermissionNum) {
			string command="SELECT * FROM cdspermission "
				+"WHERE CDSPermissionNum = "+POut.Long(cDSPermissionNum);
			List<CDSPermission> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one CDSPermission object from the database using a query.</summary>
		public static CDSPermission SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<CDSPermission> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of CDSPermission objects from the database using a query.</summary>
		public static List<CDSPermission> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<CDSPermission> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<CDSPermission> TableToList(DataTable table) {
			List<CDSPermission> retVal=new List<CDSPermission>();
			CDSPermission cDSPermission;
			foreach(DataRow row in table.Rows) {
				cDSPermission=new CDSPermission();
				cDSPermission.CDSPermissionNum= PIn.Long  (row["CDSPermissionNum"].ToString());
				cDSPermission.UserNum         = PIn.Long  (row["UserNum"].ToString());
				cDSPermission.SetupCDS        = PIn.Bool  (row["SetupCDS"].ToString());
				cDSPermission.ShowCDS         = PIn.Bool  (row["ShowCDS"].ToString());
				cDSPermission.ShowInfobutton  = PIn.Bool  (row["ShowInfobutton"].ToString());
				cDSPermission.EditBibliography= PIn.Bool  (row["EditBibliography"].ToString());
				cDSPermission.ProblemCDS      = PIn.Bool  (row["ProblemCDS"].ToString());
				cDSPermission.MedicationCDS   = PIn.Bool  (row["MedicationCDS"].ToString());
				cDSPermission.AllergyCDS      = PIn.Bool  (row["AllergyCDS"].ToString());
				cDSPermission.DemographicCDS  = PIn.Bool  (row["DemographicCDS"].ToString());
				cDSPermission.LabTestCDS      = PIn.Bool  (row["LabTestCDS"].ToString());
				cDSPermission.VitalCDS        = PIn.Bool  (row["VitalCDS"].ToString());
				retVal.Add(cDSPermission);
			}
			return retVal;
		}

		///<summary>Converts a list of CDSPermission into a DataTable.</summary>
		public static DataTable ListToTable(List<CDSPermission> listCDSPermissions,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="CDSPermission";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("CDSPermissionNum");
			table.Columns.Add("UserNum");
			table.Columns.Add("SetupCDS");
			table.Columns.Add("ShowCDS");
			table.Columns.Add("ShowInfobutton");
			table.Columns.Add("EditBibliography");
			table.Columns.Add("ProblemCDS");
			table.Columns.Add("MedicationCDS");
			table.Columns.Add("AllergyCDS");
			table.Columns.Add("DemographicCDS");
			table.Columns.Add("LabTestCDS");
			table.Columns.Add("VitalCDS");
			foreach(CDSPermission cDSPermission in listCDSPermissions) {
				table.Rows.Add(new object[] {
					POut.Long  (cDSPermission.CDSPermissionNum),
					POut.Long  (cDSPermission.UserNum),
					POut.Bool  (cDSPermission.SetupCDS),
					POut.Bool  (cDSPermission.ShowCDS),
					POut.Bool  (cDSPermission.ShowInfobutton),
					POut.Bool  (cDSPermission.EditBibliography),
					POut.Bool  (cDSPermission.ProblemCDS),
					POut.Bool  (cDSPermission.MedicationCDS),
					POut.Bool  (cDSPermission.AllergyCDS),
					POut.Bool  (cDSPermission.DemographicCDS),
					POut.Bool  (cDSPermission.LabTestCDS),
					POut.Bool  (cDSPermission.VitalCDS),
				});
			}
			return table;
		}

		///<summary>Inserts one CDSPermission into the database.  Returns the new priKey.</summary>
		public static long Insert(CDSPermission cDSPermission) {
			return Insert(cDSPermission,false);
		}

		///<summary>Inserts one CDSPermission into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(CDSPermission cDSPermission,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				cDSPermission.CDSPermissionNum=ReplicationServers.GetKey("cdspermission","CDSPermissionNum");
			}
			string command="INSERT INTO cdspermission (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="CDSPermissionNum,";
			}
			command+="UserNum,SetupCDS,ShowCDS,ShowInfobutton,EditBibliography,ProblemCDS,MedicationCDS,AllergyCDS,DemographicCDS,LabTestCDS,VitalCDS) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(cDSPermission.CDSPermissionNum)+",";
			}
			command+=
				     POut.Long  (cDSPermission.UserNum)+","
				+    POut.Bool  (cDSPermission.SetupCDS)+","
				+    POut.Bool  (cDSPermission.ShowCDS)+","
				+    POut.Bool  (cDSPermission.ShowInfobutton)+","
				+    POut.Bool  (cDSPermission.EditBibliography)+","
				+    POut.Bool  (cDSPermission.ProblemCDS)+","
				+    POut.Bool  (cDSPermission.MedicationCDS)+","
				+    POut.Bool  (cDSPermission.AllergyCDS)+","
				+    POut.Bool  (cDSPermission.DemographicCDS)+","
				+    POut.Bool  (cDSPermission.LabTestCDS)+","
				+    POut.Bool  (cDSPermission.VitalCDS)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				cDSPermission.CDSPermissionNum=Db.NonQ(command,true,"CDSPermissionNum","cDSPermission");
			}
			return cDSPermission.CDSPermissionNum;
		}

		///<summary>Inserts one CDSPermission into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(CDSPermission cDSPermission) {
			return InsertNoCache(cDSPermission,false);
		}

		///<summary>Inserts one CDSPermission into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(CDSPermission cDSPermission,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO cdspermission (";
			if(!useExistingPK && isRandomKeys) {
				cDSPermission.CDSPermissionNum=ReplicationServers.GetKeyNoCache("cdspermission","CDSPermissionNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="CDSPermissionNum,";
			}
			command+="UserNum,SetupCDS,ShowCDS,ShowInfobutton,EditBibliography,ProblemCDS,MedicationCDS,AllergyCDS,DemographicCDS,LabTestCDS,VitalCDS) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(cDSPermission.CDSPermissionNum)+",";
			}
			command+=
				     POut.Long  (cDSPermission.UserNum)+","
				+    POut.Bool  (cDSPermission.SetupCDS)+","
				+    POut.Bool  (cDSPermission.ShowCDS)+","
				+    POut.Bool  (cDSPermission.ShowInfobutton)+","
				+    POut.Bool  (cDSPermission.EditBibliography)+","
				+    POut.Bool  (cDSPermission.ProblemCDS)+","
				+    POut.Bool  (cDSPermission.MedicationCDS)+","
				+    POut.Bool  (cDSPermission.AllergyCDS)+","
				+    POut.Bool  (cDSPermission.DemographicCDS)+","
				+    POut.Bool  (cDSPermission.LabTestCDS)+","
				+    POut.Bool  (cDSPermission.VitalCDS)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				cDSPermission.CDSPermissionNum=Db.NonQ(command,true,"CDSPermissionNum","cDSPermission");
			}
			return cDSPermission.CDSPermissionNum;
		}

		///<summary>Updates one CDSPermission in the database.</summary>
		public static void Update(CDSPermission cDSPermission) {
			string command="UPDATE cdspermission SET "
				+"UserNum         =  "+POut.Long  (cDSPermission.UserNum)+", "
				+"SetupCDS        =  "+POut.Bool  (cDSPermission.SetupCDS)+", "
				+"ShowCDS         =  "+POut.Bool  (cDSPermission.ShowCDS)+", "
				+"ShowInfobutton  =  "+POut.Bool  (cDSPermission.ShowInfobutton)+", "
				+"EditBibliography=  "+POut.Bool  (cDSPermission.EditBibliography)+", "
				+"ProblemCDS      =  "+POut.Bool  (cDSPermission.ProblemCDS)+", "
				+"MedicationCDS   =  "+POut.Bool  (cDSPermission.MedicationCDS)+", "
				+"AllergyCDS      =  "+POut.Bool  (cDSPermission.AllergyCDS)+", "
				+"DemographicCDS  =  "+POut.Bool  (cDSPermission.DemographicCDS)+", "
				+"LabTestCDS      =  "+POut.Bool  (cDSPermission.LabTestCDS)+", "
				+"VitalCDS        =  "+POut.Bool  (cDSPermission.VitalCDS)+" "
				+"WHERE CDSPermissionNum = "+POut.Long(cDSPermission.CDSPermissionNum);
			Db.NonQ(command);
		}

		///<summary>Updates one CDSPermission in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(CDSPermission cDSPermission,CDSPermission oldCDSPermission) {
			string command="";
			if(cDSPermission.UserNum != oldCDSPermission.UserNum) {
				if(command!="") { command+=",";}
				command+="UserNum = "+POut.Long(cDSPermission.UserNum)+"";
			}
			if(cDSPermission.SetupCDS != oldCDSPermission.SetupCDS) {
				if(command!="") { command+=",";}
				command+="SetupCDS = "+POut.Bool(cDSPermission.SetupCDS)+"";
			}
			if(cDSPermission.ShowCDS != oldCDSPermission.ShowCDS) {
				if(command!="") { command+=",";}
				command+="ShowCDS = "+POut.Bool(cDSPermission.ShowCDS)+"";
			}
			if(cDSPermission.ShowInfobutton != oldCDSPermission.ShowInfobutton) {
				if(command!="") { command+=",";}
				command+="ShowInfobutton = "+POut.Bool(cDSPermission.ShowInfobutton)+"";
			}
			if(cDSPermission.EditBibliography != oldCDSPermission.EditBibliography) {
				if(command!="") { command+=",";}
				command+="EditBibliography = "+POut.Bool(cDSPermission.EditBibliography)+"";
			}
			if(cDSPermission.ProblemCDS != oldCDSPermission.ProblemCDS) {
				if(command!="") { command+=",";}
				command+="ProblemCDS = "+POut.Bool(cDSPermission.ProblemCDS)+"";
			}
			if(cDSPermission.MedicationCDS != oldCDSPermission.MedicationCDS) {
				if(command!="") { command+=",";}
				command+="MedicationCDS = "+POut.Bool(cDSPermission.MedicationCDS)+"";
			}
			if(cDSPermission.AllergyCDS != oldCDSPermission.AllergyCDS) {
				if(command!="") { command+=",";}
				command+="AllergyCDS = "+POut.Bool(cDSPermission.AllergyCDS)+"";
			}
			if(cDSPermission.DemographicCDS != oldCDSPermission.DemographicCDS) {
				if(command!="") { command+=",";}
				command+="DemographicCDS = "+POut.Bool(cDSPermission.DemographicCDS)+"";
			}
			if(cDSPermission.LabTestCDS != oldCDSPermission.LabTestCDS) {
				if(command!="") { command+=",";}
				command+="LabTestCDS = "+POut.Bool(cDSPermission.LabTestCDS)+"";
			}
			if(cDSPermission.VitalCDS != oldCDSPermission.VitalCDS) {
				if(command!="") { command+=",";}
				command+="VitalCDS = "+POut.Bool(cDSPermission.VitalCDS)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE cdspermission SET "+command
				+" WHERE CDSPermissionNum = "+POut.Long(cDSPermission.CDSPermissionNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(CDSPermission,CDSPermission) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(CDSPermission cDSPermission,CDSPermission oldCDSPermission) {
			if(cDSPermission.UserNum != oldCDSPermission.UserNum) {
				return true;
			}
			if(cDSPermission.SetupCDS != oldCDSPermission.SetupCDS) {
				return true;
			}
			if(cDSPermission.ShowCDS != oldCDSPermission.ShowCDS) {
				return true;
			}
			if(cDSPermission.ShowInfobutton != oldCDSPermission.ShowInfobutton) {
				return true;
			}
			if(cDSPermission.EditBibliography != oldCDSPermission.EditBibliography) {
				return true;
			}
			if(cDSPermission.ProblemCDS != oldCDSPermission.ProblemCDS) {
				return true;
			}
			if(cDSPermission.MedicationCDS != oldCDSPermission.MedicationCDS) {
				return true;
			}
			if(cDSPermission.AllergyCDS != oldCDSPermission.AllergyCDS) {
				return true;
			}
			if(cDSPermission.DemographicCDS != oldCDSPermission.DemographicCDS) {
				return true;
			}
			if(cDSPermission.LabTestCDS != oldCDSPermission.LabTestCDS) {
				return true;
			}
			if(cDSPermission.VitalCDS != oldCDSPermission.VitalCDS) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one CDSPermission from the database.</summary>
		public static void Delete(long cDSPermissionNum) {
			string command="DELETE FROM cdspermission "
				+"WHERE CDSPermissionNum = "+POut.Long(cDSPermissionNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many CDSPermissions from the database.</summary>
		public static void DeleteMany(List<long> listCDSPermissionNums) {
			if(listCDSPermissionNums==null || listCDSPermissionNums.Count==0) {
				return;
			}
			string command="DELETE FROM cdspermission "
				+"WHERE CDSPermissionNum IN("+string.Join(",",listCDSPermissionNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}