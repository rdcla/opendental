//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenDentBusiness.Crud{
	public class SigButDefCrud {
		///<summary>Gets one SigButDef object from the database using the primary key.  Returns null if not found.</summary>
		public static SigButDef SelectOne(long sigButDefNum) {
			string command="SELECT * FROM sigbutdef "
				+"WHERE SigButDefNum = "+POut.Long(sigButDefNum);
			List<SigButDef> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one SigButDef object from the database using a query.</summary>
		public static SigButDef SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<SigButDef> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of SigButDef objects from the database using a query.</summary>
		public static List<SigButDef> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<SigButDef> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<SigButDef> TableToList(DataTable table) {
			List<SigButDef> retVal=new List<SigButDef>();
			SigButDef sigButDef;
			foreach(DataRow row in table.Rows) {
				sigButDef=new SigButDef();
				sigButDef.SigButDefNum         = PIn.Long  (row["SigButDefNum"].ToString());
				sigButDef.ButtonText           = PIn.String(row["ButtonText"].ToString());
				sigButDef.ButtonIndex          = PIn.Int   (row["ButtonIndex"].ToString());
				sigButDef.SynchIcon            = PIn.Byte  (row["SynchIcon"].ToString());
				sigButDef.ComputerName         = PIn.String(row["ComputerName"].ToString());
				sigButDef.SigElementDefNumUser = PIn.Long  (row["SigElementDefNumUser"].ToString());
				sigButDef.SigElementDefNumExtra= PIn.Long  (row["SigElementDefNumExtra"].ToString());
				sigButDef.SigElementDefNumMsg  = PIn.Long  (row["SigElementDefNumMsg"].ToString());
				retVal.Add(sigButDef);
			}
			return retVal;
		}

		///<summary>Converts a list of SigButDef into a DataTable.</summary>
		public static DataTable ListToTable(List<SigButDef> listSigButDefs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="SigButDef";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("SigButDefNum");
			table.Columns.Add("ButtonText");
			table.Columns.Add("ButtonIndex");
			table.Columns.Add("SynchIcon");
			table.Columns.Add("ComputerName");
			table.Columns.Add("SigElementDefNumUser");
			table.Columns.Add("SigElementDefNumExtra");
			table.Columns.Add("SigElementDefNumMsg");
			foreach(SigButDef sigButDef in listSigButDefs) {
				table.Rows.Add(new object[] {
					POut.Long  (sigButDef.SigButDefNum),
					            sigButDef.ButtonText,
					POut.Int   (sigButDef.ButtonIndex),
					POut.Byte  (sigButDef.SynchIcon),
					            sigButDef.ComputerName,
					POut.Long  (sigButDef.SigElementDefNumUser),
					POut.Long  (sigButDef.SigElementDefNumExtra),
					POut.Long  (sigButDef.SigElementDefNumMsg),
				});
			}
			return table;
		}

		///<summary>Inserts one SigButDef into the database.  Returns the new priKey.</summary>
		public static long Insert(SigButDef sigButDef) {
			return Insert(sigButDef,false);
		}

		///<summary>Inserts one SigButDef into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(SigButDef sigButDef,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				sigButDef.SigButDefNum=ReplicationServers.GetKey("sigbutdef","SigButDefNum");
			}
			string command="INSERT INTO sigbutdef (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="SigButDefNum,";
			}
			command+="ButtonText,ButtonIndex,SynchIcon,ComputerName,SigElementDefNumUser,SigElementDefNumExtra,SigElementDefNumMsg) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(sigButDef.SigButDefNum)+",";
			}
			command+=
				 "'"+POut.String(sigButDef.ButtonText)+"',"
				+    POut.Int   (sigButDef.ButtonIndex)+","
				+    POut.Byte  (sigButDef.SynchIcon)+","
				+"'"+POut.String(sigButDef.ComputerName)+"',"
				+    POut.Long  (sigButDef.SigElementDefNumUser)+","
				+    POut.Long  (sigButDef.SigElementDefNumExtra)+","
				+    POut.Long  (sigButDef.SigElementDefNumMsg)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				sigButDef.SigButDefNum=Db.NonQ(command,true,"SigButDefNum","sigButDef");
			}
			return sigButDef.SigButDefNum;
		}

		///<summary>Inserts many SigButDefs into the database.</summary>
		public static void InsertMany(List<SigButDef> listSigButDefs) {
			InsertMany(listSigButDefs,false);
		}

		///<summary>Inserts many SigButDefs into the database.  Provides option to use the existing priKey.</summary>
		public static void InsertMany(List<SigButDef> listSigButDefs,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				foreach(SigButDef sigButDef in listSigButDefs) {
					Insert(sigButDef);
				}
			}
			else {
				StringBuilder sbCommands=null;
				int index=0;
				int countRows=0;
				while(index < listSigButDefs.Count) {
					SigButDef sigButDef=listSigButDefs[index];
					StringBuilder sbRow=new StringBuilder("(");
					bool hasComma=false;
					if(sbCommands==null) {
						sbCommands=new StringBuilder();
						sbCommands.Append("INSERT INTO sigbutdef (");
						if(useExistingPK) {
							sbCommands.Append("SigButDefNum,");
						}
						sbCommands.Append("ButtonText,ButtonIndex,SynchIcon,ComputerName,SigElementDefNumUser,SigElementDefNumExtra,SigElementDefNumMsg) VALUES ");
						countRows=0;
					}
					else {
						hasComma=true;
					}
					if(useExistingPK) {
						sbRow.Append(POut.Long(sigButDef.SigButDefNum)); sbRow.Append(",");
					}
					sbRow.Append("'"+POut.String(sigButDef.ButtonText)+"'"); sbRow.Append(",");
					sbRow.Append(POut.Int(sigButDef.ButtonIndex)); sbRow.Append(",");
					sbRow.Append(POut.Byte(sigButDef.SynchIcon)); sbRow.Append(",");
					sbRow.Append("'"+POut.String(sigButDef.ComputerName)+"'"); sbRow.Append(",");
					sbRow.Append(POut.Long(sigButDef.SigElementDefNumUser)); sbRow.Append(",");
					sbRow.Append(POut.Long(sigButDef.SigElementDefNumExtra)); sbRow.Append(",");
					sbRow.Append(POut.Long(sigButDef.SigElementDefNumMsg)); sbRow.Append(")");
					if(sbCommands.Length+sbRow.Length+1 > TableBase.MaxAllowedPacketCount && countRows > 0) {
						Db.NonQ(sbCommands.ToString());
						sbCommands=null;
					}
					else {
						if(hasComma) {
							sbCommands.Append(",");
						}
						sbCommands.Append(sbRow.ToString());
						countRows++;
						if(index==listSigButDefs.Count-1) {
							Db.NonQ(sbCommands.ToString());
						}
						index++;
					}
				}
			}
		}

		///<summary>Inserts one SigButDef into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(SigButDef sigButDef) {
			return InsertNoCache(sigButDef,false);
		}

		///<summary>Inserts one SigButDef into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(SigButDef sigButDef,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO sigbutdef (";
			if(!useExistingPK && isRandomKeys) {
				sigButDef.SigButDefNum=ReplicationServers.GetKeyNoCache("sigbutdef","SigButDefNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="SigButDefNum,";
			}
			command+="ButtonText,ButtonIndex,SynchIcon,ComputerName,SigElementDefNumUser,SigElementDefNumExtra,SigElementDefNumMsg) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(sigButDef.SigButDefNum)+",";
			}
			command+=
				 "'"+POut.String(sigButDef.ButtonText)+"',"
				+    POut.Int   (sigButDef.ButtonIndex)+","
				+    POut.Byte  (sigButDef.SynchIcon)+","
				+"'"+POut.String(sigButDef.ComputerName)+"',"
				+    POut.Long  (sigButDef.SigElementDefNumUser)+","
				+    POut.Long  (sigButDef.SigElementDefNumExtra)+","
				+    POut.Long  (sigButDef.SigElementDefNumMsg)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				sigButDef.SigButDefNum=Db.NonQ(command,true,"SigButDefNum","sigButDef");
			}
			return sigButDef.SigButDefNum;
		}

		///<summary>Updates one SigButDef in the database.</summary>
		public static void Update(SigButDef sigButDef) {
			string command="UPDATE sigbutdef SET "
				+"ButtonText           = '"+POut.String(sigButDef.ButtonText)+"', "
				+"ButtonIndex          =  "+POut.Int   (sigButDef.ButtonIndex)+", "
				+"SynchIcon            =  "+POut.Byte  (sigButDef.SynchIcon)+", "
				+"ComputerName         = '"+POut.String(sigButDef.ComputerName)+"', "
				+"SigElementDefNumUser =  "+POut.Long  (sigButDef.SigElementDefNumUser)+", "
				+"SigElementDefNumExtra=  "+POut.Long  (sigButDef.SigElementDefNumExtra)+", "
				+"SigElementDefNumMsg  =  "+POut.Long  (sigButDef.SigElementDefNumMsg)+" "
				+"WHERE SigButDefNum = "+POut.Long(sigButDef.SigButDefNum);
			Db.NonQ(command);
		}

		///<summary>Updates one SigButDef in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(SigButDef sigButDef,SigButDef oldSigButDef) {
			string command="";
			if(sigButDef.ButtonText != oldSigButDef.ButtonText) {
				if(command!="") { command+=",";}
				command+="ButtonText = '"+POut.String(sigButDef.ButtonText)+"'";
			}
			if(sigButDef.ButtonIndex != oldSigButDef.ButtonIndex) {
				if(command!="") { command+=",";}
				command+="ButtonIndex = "+POut.Int(sigButDef.ButtonIndex)+"";
			}
			if(sigButDef.SynchIcon != oldSigButDef.SynchIcon) {
				if(command!="") { command+=",";}
				command+="SynchIcon = "+POut.Byte(sigButDef.SynchIcon)+"";
			}
			if(sigButDef.ComputerName != oldSigButDef.ComputerName) {
				if(command!="") { command+=",";}
				command+="ComputerName = '"+POut.String(sigButDef.ComputerName)+"'";
			}
			if(sigButDef.SigElementDefNumUser != oldSigButDef.SigElementDefNumUser) {
				if(command!="") { command+=",";}
				command+="SigElementDefNumUser = "+POut.Long(sigButDef.SigElementDefNumUser)+"";
			}
			if(sigButDef.SigElementDefNumExtra != oldSigButDef.SigElementDefNumExtra) {
				if(command!="") { command+=",";}
				command+="SigElementDefNumExtra = "+POut.Long(sigButDef.SigElementDefNumExtra)+"";
			}
			if(sigButDef.SigElementDefNumMsg != oldSigButDef.SigElementDefNumMsg) {
				if(command!="") { command+=",";}
				command+="SigElementDefNumMsg = "+POut.Long(sigButDef.SigElementDefNumMsg)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE sigbutdef SET "+command
				+" WHERE SigButDefNum = "+POut.Long(sigButDef.SigButDefNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(SigButDef,SigButDef) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(SigButDef sigButDef,SigButDef oldSigButDef) {
			if(sigButDef.ButtonText != oldSigButDef.ButtonText) {
				return true;
			}
			if(sigButDef.ButtonIndex != oldSigButDef.ButtonIndex) {
				return true;
			}
			if(sigButDef.SynchIcon != oldSigButDef.SynchIcon) {
				return true;
			}
			if(sigButDef.ComputerName != oldSigButDef.ComputerName) {
				return true;
			}
			if(sigButDef.SigElementDefNumUser != oldSigButDef.SigElementDefNumUser) {
				return true;
			}
			if(sigButDef.SigElementDefNumExtra != oldSigButDef.SigElementDefNumExtra) {
				return true;
			}
			if(sigButDef.SigElementDefNumMsg != oldSigButDef.SigElementDefNumMsg) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one SigButDef from the database.</summary>
		public static void Delete(long sigButDefNum) {
			string command="DELETE FROM sigbutdef "
				+"WHERE SigButDefNum = "+POut.Long(sigButDefNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many SigButDefs from the database.</summary>
		public static void DeleteMany(List<long> listSigButDefNums) {
			if(listSigButDefNums==null || listSigButDefNums.Count==0) {
				return;
			}
			string command="DELETE FROM sigbutdef "
				+"WHERE SigButDefNum IN("+string.Join(",",listSigButDefNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

		///<summary>Inserts, updates, or deletes database rows to match supplied list.  Returns true if db changes were made.
		///Caution: Uses InsertMany for inserts, so the objects in listNew will not have primary keys set.</summary>
		public static bool Sync(List<SigButDef> listNew,List<SigButDef> listDB) {
			//Adding items to lists changes the order of operation. All inserts are completed first, then updates, then deletes.
			List<SigButDef> listIns    =new List<SigButDef>();
			List<SigButDef> listUpdNew =new List<SigButDef>();
			List<SigButDef> listUpdDB  =new List<SigButDef>();
			List<SigButDef> listDel    =new List<SigButDef>();
			listNew.Sort((SigButDef x,SigButDef y) => { return x.SigButDefNum.CompareTo(y.SigButDefNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			listDB.Sort((SigButDef x,SigButDef y) => { return x.SigButDefNum.CompareTo(y.SigButDefNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			int idxNew=0;
			int idxDB=0;
			int rowsUpdatedCount=0;
			SigButDef fieldNew;
			SigButDef fieldDB;
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
				else if(fieldNew.SigButDefNum<fieldDB.SigButDefNum) {//newPK less than dbPK, newItem is 'next'
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew.SigButDefNum>fieldDB.SigButDefNum) {//dbPK less than newPK, dbItem is 'next'
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
			InsertMany(listIns);
			for(int i=0;i<listUpdNew.Count;i++) {
				if(Update(listUpdNew[i],listUpdDB[i])) {
					rowsUpdatedCount++;
				}
			}
			DeleteMany(listDel.Select(x => x.SigButDefNum).ToList());
			if(rowsUpdatedCount>0 || listIns.Count>0 || listDel.Count>0) {
				return true;
			}
			return false;
		}

	}
}