//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class JobTeamUserCrud {
		///<summary>Gets one JobTeamUser object from the database using the primary key.  Returns null if not found.</summary>
		public static JobTeamUser SelectOne(long jobTeamUserNum) {
			string command="SELECT * FROM jobteamuser "
				+"WHERE JobTeamUserNum = "+POut.Long(jobTeamUserNum);
			List<JobTeamUser> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one JobTeamUser object from the database using a query.</summary>
		public static JobTeamUser SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<JobTeamUser> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of JobTeamUser objects from the database using a query.</summary>
		public static List<JobTeamUser> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<JobTeamUser> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<JobTeamUser> TableToList(DataTable table) {
			List<JobTeamUser> retVal=new List<JobTeamUser>();
			JobTeamUser jobTeamUser;
			foreach(DataRow row in table.Rows) {
				jobTeamUser=new JobTeamUser();
				jobTeamUser.JobTeamUserNum = PIn.Long  (row["JobTeamUserNum"].ToString());
				jobTeamUser.JobTeamNum     = PIn.Long  (row["JobTeamNum"].ToString());
				jobTeamUser.UserNumEngineer= PIn.Long  (row["UserNumEngineer"].ToString());
				jobTeamUser.IsTeamLead     = PIn.Bool  (row["IsTeamLead"].ToString());
				retVal.Add(jobTeamUser);
			}
			return retVal;
		}

		///<summary>Converts a list of JobTeamUser into a DataTable.</summary>
		public static DataTable ListToTable(List<JobTeamUser> listJobTeamUsers,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="JobTeamUser";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("JobTeamUserNum");
			table.Columns.Add("JobTeamNum");
			table.Columns.Add("UserNumEngineer");
			table.Columns.Add("IsTeamLead");
			foreach(JobTeamUser jobTeamUser in listJobTeamUsers) {
				table.Rows.Add(new object[] {
					POut.Long  (jobTeamUser.JobTeamUserNum),
					POut.Long  (jobTeamUser.JobTeamNum),
					POut.Long  (jobTeamUser.UserNumEngineer),
					POut.Bool  (jobTeamUser.IsTeamLead),
				});
			}
			return table;
		}

		///<summary>Inserts one JobTeamUser into the database.  Returns the new priKey.</summary>
		public static long Insert(JobTeamUser jobTeamUser) {
			return Insert(jobTeamUser,false);
		}

		///<summary>Inserts one JobTeamUser into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(JobTeamUser jobTeamUser,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				jobTeamUser.JobTeamUserNum=ReplicationServers.GetKey("jobteamuser","JobTeamUserNum");
			}
			string command="INSERT INTO jobteamuser (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="JobTeamUserNum,";
			}
			command+="JobTeamNum,UserNumEngineer,IsTeamLead) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(jobTeamUser.JobTeamUserNum)+",";
			}
			command+=
				     POut.Long  (jobTeamUser.JobTeamNum)+","
				+    POut.Long  (jobTeamUser.UserNumEngineer)+","
				+    POut.Bool  (jobTeamUser.IsTeamLead)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				jobTeamUser.JobTeamUserNum=Db.NonQ(command,true,"JobTeamUserNum","jobTeamUser");
			}
			return jobTeamUser.JobTeamUserNum;
		}

		///<summary>Inserts one JobTeamUser into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(JobTeamUser jobTeamUser) {
			return InsertNoCache(jobTeamUser,false);
		}

		///<summary>Inserts one JobTeamUser into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(JobTeamUser jobTeamUser,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO jobteamuser (";
			if(!useExistingPK && isRandomKeys) {
				jobTeamUser.JobTeamUserNum=ReplicationServers.GetKeyNoCache("jobteamuser","JobTeamUserNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="JobTeamUserNum,";
			}
			command+="JobTeamNum,UserNumEngineer,IsTeamLead) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(jobTeamUser.JobTeamUserNum)+",";
			}
			command+=
				     POut.Long  (jobTeamUser.JobTeamNum)+","
				+    POut.Long  (jobTeamUser.UserNumEngineer)+","
				+    POut.Bool  (jobTeamUser.IsTeamLead)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				jobTeamUser.JobTeamUserNum=Db.NonQ(command,true,"JobTeamUserNum","jobTeamUser");
			}
			return jobTeamUser.JobTeamUserNum;
		}

		///<summary>Updates one JobTeamUser in the database.</summary>
		public static void Update(JobTeamUser jobTeamUser) {
			string command="UPDATE jobteamuser SET "
				+"JobTeamNum     =  "+POut.Long  (jobTeamUser.JobTeamNum)+", "
				+"UserNumEngineer=  "+POut.Long  (jobTeamUser.UserNumEngineer)+", "
				+"IsTeamLead     =  "+POut.Bool  (jobTeamUser.IsTeamLead)+" "
				+"WHERE JobTeamUserNum = "+POut.Long(jobTeamUser.JobTeamUserNum);
			Db.NonQ(command);
		}

		///<summary>Updates one JobTeamUser in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(JobTeamUser jobTeamUser,JobTeamUser oldJobTeamUser) {
			string command="";
			if(jobTeamUser.JobTeamNum != oldJobTeamUser.JobTeamNum) {
				if(command!="") { command+=",";}
				command+="JobTeamNum = "+POut.Long(jobTeamUser.JobTeamNum)+"";
			}
			if(jobTeamUser.UserNumEngineer != oldJobTeamUser.UserNumEngineer) {
				if(command!="") { command+=",";}
				command+="UserNumEngineer = "+POut.Long(jobTeamUser.UserNumEngineer)+"";
			}
			if(jobTeamUser.IsTeamLead != oldJobTeamUser.IsTeamLead) {
				if(command!="") { command+=",";}
				command+="IsTeamLead = "+POut.Bool(jobTeamUser.IsTeamLead)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE jobteamuser SET "+command
				+" WHERE JobTeamUserNum = "+POut.Long(jobTeamUser.JobTeamUserNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(JobTeamUser,JobTeamUser) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(JobTeamUser jobTeamUser,JobTeamUser oldJobTeamUser) {
			if(jobTeamUser.JobTeamNum != oldJobTeamUser.JobTeamNum) {
				return true;
			}
			if(jobTeamUser.UserNumEngineer != oldJobTeamUser.UserNumEngineer) {
				return true;
			}
			if(jobTeamUser.IsTeamLead != oldJobTeamUser.IsTeamLead) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one JobTeamUser from the database.</summary>
		public static void Delete(long jobTeamUserNum) {
			string command="DELETE FROM jobteamuser "
				+"WHERE JobTeamUserNum = "+POut.Long(jobTeamUserNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many JobTeamUsers from the database.</summary>
		public static void DeleteMany(List<long> listJobTeamUserNums) {
			if(listJobTeamUserNums==null || listJobTeamUserNums.Count==0) {
				return;
			}
			string command="DELETE FROM jobteamuser "
				+"WHERE JobTeamUserNum IN("+string.Join(",",listJobTeamUserNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

		///<summary>Inserts, updates, or deletes database rows to match supplied list.  Returns true if db changes were made.</summary>
		public static bool Sync(List<JobTeamUser> listNew,List<JobTeamUser> listDB) {
			//Adding items to lists changes the order of operation. All inserts are completed first, then updates, then deletes.
			List<JobTeamUser> listIns    =new List<JobTeamUser>();
			List<JobTeamUser> listUpdNew =new List<JobTeamUser>();
			List<JobTeamUser> listUpdDB  =new List<JobTeamUser>();
			List<JobTeamUser> listDel    =new List<JobTeamUser>();
			listNew.Sort((JobTeamUser x,JobTeamUser y) => { return x.JobTeamUserNum.CompareTo(y.JobTeamUserNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			listDB.Sort((JobTeamUser x,JobTeamUser y) => { return x.JobTeamUserNum.CompareTo(y.JobTeamUserNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			int idxNew=0;
			int idxDB=0;
			int rowsUpdatedCount=0;
			JobTeamUser fieldNew;
			JobTeamUser fieldDB;
			//Because both lists have been sorted using the same criteria, we can now walk each list to determine which list contians the next element.  The next element is determined by Primary Key.
			//If the New list contains the next item it will be inserted.  If the DB contains the next item, it will be deleted.  If both lists contain the next item, the item will be updated.
			while(idxNew<listNew.Count || idxDB<listDB.Count) {
				fieldNew=null;
				if(idxNew<listNew.Count) {
					fieldNew=listNew[idxNew];
				}
				fieldDB=null;
				if(idxDB<listDB.Count) {
					fieldDB=listDB[idxDB];
				}
				//begin compare
				if(fieldNew!=null && fieldDB==null) {//listNew has more items, listDB does not.
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew==null && fieldDB!=null) {//listDB has more items, listNew does not.
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				else if(fieldNew.JobTeamUserNum<fieldDB.JobTeamUserNum) {//newPK less than dbPK, newItem is 'next'
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew.JobTeamUserNum>fieldDB.JobTeamUserNum) {//dbPK less than newPK, dbItem is 'next'
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				//Both lists contain the 'next' item, update required
				listUpdNew.Add(fieldNew);
				listUpdDB.Add(fieldDB);
				idxNew++;
				idxDB++;
			}
			//Commit changes to DB
			for(int i=0;i<listIns.Count;i++) {
				Insert(listIns[i]);
			}
			for(int i=0;i<listUpdNew.Count;i++) {
				if(Update(listUpdNew[i],listUpdDB[i])) {
					rowsUpdatedCount++;
				}
			}
			DeleteMany(listDel.Select(x => x.JobTeamUserNum).ToList());
			if(rowsUpdatedCount>0 || listIns.Count>0 || listDel.Count>0) {
				return true;
			}
			return false;
		}

	}
}