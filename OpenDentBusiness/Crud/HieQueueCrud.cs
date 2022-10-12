//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class HieQueueCrud {
		///<summary>Gets one HieQueue object from the database using the primary key.  Returns null if not found.</summary>
		public static HieQueue SelectOne(long hieQueueNum) {
			string command="SELECT * FROM hiequeue "
				+"WHERE HieQueueNum = "+POut.Long(hieQueueNum);
			List<HieQueue> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one HieQueue object from the database using a query.</summary>
		public static HieQueue SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<HieQueue> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of HieQueue objects from the database using a query.</summary>
		public static List<HieQueue> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<HieQueue> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<HieQueue> TableToList(DataTable table) {
			List<HieQueue> retVal=new List<HieQueue>();
			HieQueue hieQueue;
			foreach(DataRow row in table.Rows) {
				hieQueue=new HieQueue();
				hieQueue.HieQueueNum= PIn.Long  (row["HieQueueNum"].ToString());
				hieQueue.PatNum     = PIn.Long  (row["PatNum"].ToString());
				retVal.Add(hieQueue);
			}
			return retVal;
		}

		///<summary>Converts a list of HieQueue into a DataTable.</summary>
		public static DataTable ListToTable(List<HieQueue> listHieQueues,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="HieQueue";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("HieQueueNum");
			table.Columns.Add("PatNum");
			foreach(HieQueue hieQueue in listHieQueues) {
				table.Rows.Add(new object[] {
					POut.Long  (hieQueue.HieQueueNum),
					POut.Long  (hieQueue.PatNum),
				});
			}
			return table;
		}

		///<summary>Inserts one HieQueue into the database.  Returns the new priKey.</summary>
		public static long Insert(HieQueue hieQueue) {
			return Insert(hieQueue,false);
		}

		///<summary>Inserts one HieQueue into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(HieQueue hieQueue,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				hieQueue.HieQueueNum=ReplicationServers.GetKey("hiequeue","HieQueueNum");
			}
			string command="INSERT INTO hiequeue (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="HieQueueNum,";
			}
			command+="PatNum) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(hieQueue.HieQueueNum)+",";
			}
			command+=
				     POut.Long  (hieQueue.PatNum)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				hieQueue.HieQueueNum=Db.NonQ(command,true,"HieQueueNum","hieQueue");
			}
			return hieQueue.HieQueueNum;
		}

		///<summary>Inserts one HieQueue into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(HieQueue hieQueue) {
			return InsertNoCache(hieQueue,false);
		}

		///<summary>Inserts one HieQueue into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(HieQueue hieQueue,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO hiequeue (";
			if(!useExistingPK && isRandomKeys) {
				hieQueue.HieQueueNum=ReplicationServers.GetKeyNoCache("hiequeue","HieQueueNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="HieQueueNum,";
			}
			command+="PatNum) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(hieQueue.HieQueueNum)+",";
			}
			command+=
				     POut.Long  (hieQueue.PatNum)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				hieQueue.HieQueueNum=Db.NonQ(command,true,"HieQueueNum","hieQueue");
			}
			return hieQueue.HieQueueNum;
		}

		///<summary>Updates one HieQueue in the database.</summary>
		public static void Update(HieQueue hieQueue) {
			string command="UPDATE hiequeue SET "
				+"PatNum     =  "+POut.Long  (hieQueue.PatNum)+" "
				+"WHERE HieQueueNum = "+POut.Long(hieQueue.HieQueueNum);
			Db.NonQ(command);
		}

		///<summary>Updates one HieQueue in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(HieQueue hieQueue,HieQueue oldHieQueue) {
			string command="";
			if(hieQueue.PatNum != oldHieQueue.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(hieQueue.PatNum)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE hiequeue SET "+command
				+" WHERE HieQueueNum = "+POut.Long(hieQueue.HieQueueNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(HieQueue,HieQueue) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(HieQueue hieQueue,HieQueue oldHieQueue) {
			if(hieQueue.PatNum != oldHieQueue.PatNum) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one HieQueue from the database.</summary>
		public static void Delete(long hieQueueNum) {
			string command="DELETE FROM hiequeue "
				+"WHERE HieQueueNum = "+POut.Long(hieQueueNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many HieQueues from the database.</summary>
		public static void DeleteMany(List<long> listHieQueueNums) {
			if(listHieQueueNums==null || listHieQueueNums.Count==0) {
				return;
			}
			string command="DELETE FROM hiequeue "
				+"WHERE HieQueueNum IN("+string.Join(",",listHieQueueNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}