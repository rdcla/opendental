//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class JobTeamCrud {
		///<summary>Gets one JobTeam object from the database using the primary key.  Returns null if not found.</summary>
		public static JobTeam SelectOne(long jobTeamNum) {
			string command="SELECT * FROM jobteam "
				+"WHERE JobTeamNum = "+POut.Long(jobTeamNum);
			List<JobTeam> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one JobTeam object from the database using a query.</summary>
		public static JobTeam SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<JobTeam> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of JobTeam objects from the database using a query.</summary>
		public static List<JobTeam> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<JobTeam> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<JobTeam> TableToList(DataTable table) {
			List<JobTeam> retVal=new List<JobTeam>();
			JobTeam jobTeam;
			foreach(DataRow row in table.Rows) {
				jobTeam=new JobTeam();
				jobTeam.JobTeamNum     = PIn.Long  (row["JobTeamNum"].ToString());
				jobTeam.TeamName       = PIn.String(row["TeamName"].ToString());
				jobTeam.TeamDescription= PIn.String(row["TeamDescription"].ToString());
				jobTeam.TeamFocus      = (OpenDentBusiness.JobTeamFocus)PIn.Int(row["TeamFocus"].ToString());
				retVal.Add(jobTeam);
			}
			return retVal;
		}

		///<summary>Converts a list of JobTeam into a DataTable.</summary>
		public static DataTable ListToTable(List<JobTeam> listJobTeams,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="JobTeam";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("JobTeamNum");
			table.Columns.Add("TeamName");
			table.Columns.Add("TeamDescription");
			table.Columns.Add("TeamFocus");
			foreach(JobTeam jobTeam in listJobTeams) {
				table.Rows.Add(new object[] {
					POut.Long  (jobTeam.JobTeamNum),
					            jobTeam.TeamName,
					            jobTeam.TeamDescription,
					POut.Int   ((int)jobTeam.TeamFocus),
				});
			}
			return table;
		}

		///<summary>Inserts one JobTeam into the database.  Returns the new priKey.</summary>
		public static long Insert(JobTeam jobTeam) {
			return Insert(jobTeam,false);
		}

		///<summary>Inserts one JobTeam into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(JobTeam jobTeam,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				jobTeam.JobTeamNum=ReplicationServers.GetKey("jobteam","JobTeamNum");
			}
			string command="INSERT INTO jobteam (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="JobTeamNum,";
			}
			command+="TeamName,TeamDescription,TeamFocus) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(jobTeam.JobTeamNum)+",";
			}
			command+=
				 "'"+POut.String(jobTeam.TeamName)+"',"
				+"'"+POut.String(jobTeam.TeamDescription)+"',"
				+    POut.Int   ((int)jobTeam.TeamFocus)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				jobTeam.JobTeamNum=Db.NonQ(command,true,"JobTeamNum","jobTeam");
			}
			return jobTeam.JobTeamNum;
		}

		///<summary>Inserts one JobTeam into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(JobTeam jobTeam) {
			return InsertNoCache(jobTeam,false);
		}

		///<summary>Inserts one JobTeam into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(JobTeam jobTeam,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO jobteam (";
			if(!useExistingPK && isRandomKeys) {
				jobTeam.JobTeamNum=ReplicationServers.GetKeyNoCache("jobteam","JobTeamNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="JobTeamNum,";
			}
			command+="TeamName,TeamDescription,TeamFocus) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(jobTeam.JobTeamNum)+",";
			}
			command+=
				 "'"+POut.String(jobTeam.TeamName)+"',"
				+"'"+POut.String(jobTeam.TeamDescription)+"',"
				+    POut.Int   ((int)jobTeam.TeamFocus)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				jobTeam.JobTeamNum=Db.NonQ(command,true,"JobTeamNum","jobTeam");
			}
			return jobTeam.JobTeamNum;
		}

		///<summary>Updates one JobTeam in the database.</summary>
		public static void Update(JobTeam jobTeam) {
			string command="UPDATE jobteam SET "
				+"TeamName       = '"+POut.String(jobTeam.TeamName)+"', "
				+"TeamDescription= '"+POut.String(jobTeam.TeamDescription)+"', "
				+"TeamFocus      =  "+POut.Int   ((int)jobTeam.TeamFocus)+" "
				+"WHERE JobTeamNum = "+POut.Long(jobTeam.JobTeamNum);
			Db.NonQ(command);
		}

		///<summary>Updates one JobTeam in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(JobTeam jobTeam,JobTeam oldJobTeam) {
			string command="";
			if(jobTeam.TeamName != oldJobTeam.TeamName) {
				if(command!="") { command+=",";}
				command+="TeamName = '"+POut.String(jobTeam.TeamName)+"'";
			}
			if(jobTeam.TeamDescription != oldJobTeam.TeamDescription) {
				if(command!="") { command+=",";}
				command+="TeamDescription = '"+POut.String(jobTeam.TeamDescription)+"'";
			}
			if(jobTeam.TeamFocus != oldJobTeam.TeamFocus) {
				if(command!="") { command+=",";}
				command+="TeamFocus = "+POut.Int   ((int)jobTeam.TeamFocus)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE jobteam SET "+command
				+" WHERE JobTeamNum = "+POut.Long(jobTeam.JobTeamNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(JobTeam,JobTeam) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(JobTeam jobTeam,JobTeam oldJobTeam) {
			if(jobTeam.TeamName != oldJobTeam.TeamName) {
				return true;
			}
			if(jobTeam.TeamDescription != oldJobTeam.TeamDescription) {
				return true;
			}
			if(jobTeam.TeamFocus != oldJobTeam.TeamFocus) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one JobTeam from the database.</summary>
		public static void Delete(long jobTeamNum) {
			string command="DELETE FROM jobteam "
				+"WHERE JobTeamNum = "+POut.Long(jobTeamNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many JobTeams from the database.</summary>
		public static void DeleteMany(List<long> listJobTeamNums) {
			if(listJobTeamNums==null || listJobTeamNums.Count==0) {
				return;
			}
			string command="DELETE FROM jobteam "
				+"WHERE JobTeamNum IN("+string.Join(",",listJobTeamNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

		///<summary>Inserts, updates, or deletes database rows to match supplied list.  Returns true if db changes were made.</summary>
		public static bool Sync(List<JobTeam> listNew,List<JobTeam> listDB) {
			//Adding items to lists changes the order of operation. All inserts are completed first, then updates, then deletes.
			List<JobTeam> listIns    =new List<JobTeam>();
			List<JobTeam> listUpdNew =new List<JobTeam>();
			List<JobTeam> listUpdDB  =new List<JobTeam>();
			List<JobTeam> listDel    =new List<JobTeam>();
			listNew.Sort((JobTeam x,JobTeam y) => { return x.JobTeamNum.CompareTo(y.JobTeamNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			listDB.Sort((JobTeam x,JobTeam y) => { return x.JobTeamNum.CompareTo(y.JobTeamNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			int idxNew=0;
			int idxDB=0;
			int rowsUpdatedCount=0;
			JobTeam fieldNew;
			JobTeam fieldDB;
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
				else if(fieldNew.JobTeamNum<fieldDB.JobTeamNum) {//newPK less than dbPK, newItem is 'next'
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew.JobTeamNum>fieldDB.JobTeamNum) {//dbPK less than newPK, dbItem is 'next'
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
			DeleteMany(listDel.Select(x => x.JobTeamNum).ToList());
			if(rowsUpdatedCount>0 || listIns.Count>0 || listDel.Count>0) {
				return true;
			}
			return false;
		}

	}
}