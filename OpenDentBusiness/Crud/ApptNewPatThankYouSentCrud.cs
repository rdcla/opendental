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
	public class ApptNewPatThankYouSentCrud {
		///<summary>Gets one ApptNewPatThankYouSent object from the database using the primary key.  Returns null if not found.</summary>
		public static ApptNewPatThankYouSent SelectOne(long apptNewPatThankYouSentNum) {
			string command="SELECT * FROM apptnewpatthankyousent "
				+"WHERE ApptNewPatThankYouSentNum = "+POut.Long(apptNewPatThankYouSentNum);
			List<ApptNewPatThankYouSent> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one ApptNewPatThankYouSent object from the database using a query.</summary>
		public static ApptNewPatThankYouSent SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ApptNewPatThankYouSent> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of ApptNewPatThankYouSent objects from the database using a query.</summary>
		public static List<ApptNewPatThankYouSent> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ApptNewPatThankYouSent> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<ApptNewPatThankYouSent> TableToList(DataTable table) {
			List<ApptNewPatThankYouSent> retVal=new List<ApptNewPatThankYouSent>();
			ApptNewPatThankYouSent apptNewPatThankYouSent;
			foreach(DataRow row in table.Rows) {
				apptNewPatThankYouSent=new ApptNewPatThankYouSent();
				apptNewPatThankYouSent.ApptNewPatThankYouSentNum     = PIn.Long  (row["ApptNewPatThankYouSentNum"].ToString());
				apptNewPatThankYouSent.ApptSecDateTEntry             = PIn.DateT (row["ApptSecDateTEntry"].ToString());
				apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit= PIn.DateT (row["DateTimeNewPatThankYouTransmit"].ToString());
				apptNewPatThankYouSent.PatNum                        = PIn.Long  (row["PatNum"].ToString());
				apptNewPatThankYouSent.ClinicNum                     = PIn.Long  (row["ClinicNum"].ToString());
				apptNewPatThankYouSent.SendStatus                    = (OpenDentBusiness.AutoCommStatus)PIn.Int(row["SendStatus"].ToString());
				apptNewPatThankYouSent.MessageType                   = (OpenDentBusiness.CommType)PIn.Int(row["MessageType"].ToString());
				apptNewPatThankYouSent.MessageFk                     = PIn.Long  (row["MessageFk"].ToString());
				apptNewPatThankYouSent.DateTimeEntry                 = PIn.DateT (row["DateTimeEntry"].ToString());
				apptNewPatThankYouSent.DateTimeSent                  = PIn.DateT (row["DateTimeSent"].ToString());
				apptNewPatThankYouSent.ResponseDescript              = PIn.String(row["ResponseDescript"].ToString());
				apptNewPatThankYouSent.ApptReminderRuleNum           = PIn.Long  (row["ApptReminderRuleNum"].ToString());
				apptNewPatThankYouSent.ApptNum                       = PIn.Long  (row["ApptNum"].ToString());
				apptNewPatThankYouSent.ApptDateTime                  = PIn.DateT (row["ApptDateTime"].ToString());
				apptNewPatThankYouSent.TSPrior                       = TimeSpan.FromTicks(PIn.Long(row["TSPrior"].ToString()));
				apptNewPatThankYouSent.ShortGUID                     = PIn.String(row["ShortGUID"].ToString());
				retVal.Add(apptNewPatThankYouSent);
			}
			return retVal;
		}

		///<summary>Converts a list of ApptNewPatThankYouSent into a DataTable.</summary>
		public static DataTable ListToTable(List<ApptNewPatThankYouSent> listApptNewPatThankYouSents,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="ApptNewPatThankYouSent";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ApptNewPatThankYouSentNum");
			table.Columns.Add("ApptSecDateTEntry");
			table.Columns.Add("DateTimeNewPatThankYouTransmit");
			table.Columns.Add("PatNum");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("SendStatus");
			table.Columns.Add("MessageType");
			table.Columns.Add("MessageFk");
			table.Columns.Add("DateTimeEntry");
			table.Columns.Add("DateTimeSent");
			table.Columns.Add("ResponseDescript");
			table.Columns.Add("ApptReminderRuleNum");
			table.Columns.Add("ApptNum");
			table.Columns.Add("ApptDateTime");
			table.Columns.Add("TSPrior");
			table.Columns.Add("ShortGUID");
			foreach(ApptNewPatThankYouSent apptNewPatThankYouSent in listApptNewPatThankYouSents) {
				table.Rows.Add(new object[] {
					POut.Long  (apptNewPatThankYouSent.ApptNewPatThankYouSentNum),
					POut.DateT (apptNewPatThankYouSent.ApptSecDateTEntry,false),
					POut.DateT (apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit,false),
					POut.Long  (apptNewPatThankYouSent.PatNum),
					POut.Long  (apptNewPatThankYouSent.ClinicNum),
					POut.Int   ((int)apptNewPatThankYouSent.SendStatus),
					POut.Int   ((int)apptNewPatThankYouSent.MessageType),
					POut.Long  (apptNewPatThankYouSent.MessageFk),
					POut.DateT (apptNewPatThankYouSent.DateTimeEntry,false),
					POut.DateT (apptNewPatThankYouSent.DateTimeSent,false),
					            apptNewPatThankYouSent.ResponseDescript,
					POut.Long  (apptNewPatThankYouSent.ApptReminderRuleNum),
					POut.Long  (apptNewPatThankYouSent.ApptNum),
					POut.DateT (apptNewPatThankYouSent.ApptDateTime,false),
					POut.Long (apptNewPatThankYouSent.TSPrior.Ticks),
					            apptNewPatThankYouSent.ShortGUID,
				});
			}
			return table;
		}

		///<summary>Inserts one ApptNewPatThankYouSent into the database.  Returns the new priKey.</summary>
		public static long Insert(ApptNewPatThankYouSent apptNewPatThankYouSent) {
			return Insert(apptNewPatThankYouSent,false);
		}

		///<summary>Inserts one ApptNewPatThankYouSent into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(ApptNewPatThankYouSent apptNewPatThankYouSent,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				apptNewPatThankYouSent.ApptNewPatThankYouSentNum=ReplicationServers.GetKey("apptnewpatthankyousent","ApptNewPatThankYouSentNum");
			}
			string command="INSERT INTO apptnewpatthankyousent (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ApptNewPatThankYouSentNum,";
			}
			command+="ApptSecDateTEntry,DateTimeNewPatThankYouTransmit,PatNum,ClinicNum,SendStatus,MessageType,MessageFk,DateTimeEntry,DateTimeSent,ResponseDescript,ApptReminderRuleNum,ApptNum,ApptDateTime,TSPrior,ShortGUID) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(apptNewPatThankYouSent.ApptNewPatThankYouSentNum)+",";
			}
			command+=
				     POut.DateT (apptNewPatThankYouSent.ApptSecDateTEntry)+","
				+    POut.DateT (apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit)+","
				+    POut.Long  (apptNewPatThankYouSent.PatNum)+","
				+    POut.Long  (apptNewPatThankYouSent.ClinicNum)+","
				+    POut.Int   ((int)apptNewPatThankYouSent.SendStatus)+","
				+    POut.Int   ((int)apptNewPatThankYouSent.MessageType)+","
				+    POut.Long  (apptNewPatThankYouSent.MessageFk)+","
				+    DbHelper.Now()+","
				+    POut.DateT (apptNewPatThankYouSent.DateTimeSent)+","
				+    DbHelper.ParamChar+"paramResponseDescript,"
				+    POut.Long  (apptNewPatThankYouSent.ApptReminderRuleNum)+","
				+    POut.Long  (apptNewPatThankYouSent.ApptNum)+","
				+    POut.DateT (apptNewPatThankYouSent.ApptDateTime)+","
				+"'"+POut.Long  (apptNewPatThankYouSent.TSPrior.Ticks)+"',"
				+"'"+POut.String(apptNewPatThankYouSent.ShortGUID)+"')";
			if(apptNewPatThankYouSent.ResponseDescript==null) {
				apptNewPatThankYouSent.ResponseDescript="";
			}
			OdSqlParameter paramResponseDescript=new OdSqlParameter("paramResponseDescript",OdDbType.Text,POut.StringParam(apptNewPatThankYouSent.ResponseDescript));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramResponseDescript);
			}
			else {
				apptNewPatThankYouSent.ApptNewPatThankYouSentNum=Db.NonQ(command,true,"ApptNewPatThankYouSentNum","apptNewPatThankYouSent",paramResponseDescript);
			}
			return apptNewPatThankYouSent.ApptNewPatThankYouSentNum;
		}

		///<summary>Inserts many ApptNewPatThankYouSents into the database.</summary>
		public static void InsertMany(List<ApptNewPatThankYouSent> listApptNewPatThankYouSents) {
			InsertMany(listApptNewPatThankYouSents,false);
		}

		///<summary>Inserts many ApptNewPatThankYouSents into the database.  Provides option to use the existing priKey.</summary>
		public static void InsertMany(List<ApptNewPatThankYouSent> listApptNewPatThankYouSents,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				foreach(ApptNewPatThankYouSent apptNewPatThankYouSent in listApptNewPatThankYouSents) {
					Insert(apptNewPatThankYouSent);
				}
			}
			else {
				StringBuilder sbCommands=null;
				int index=0;
				int countRows=0;
				while(index < listApptNewPatThankYouSents.Count) {
					ApptNewPatThankYouSent apptNewPatThankYouSent=listApptNewPatThankYouSents[index];
					StringBuilder sbRow=new StringBuilder("(");
					bool hasComma=false;
					if(sbCommands==null) {
						sbCommands=new StringBuilder();
						sbCommands.Append("INSERT INTO apptnewpatthankyousent (");
						if(useExistingPK) {
							sbCommands.Append("ApptNewPatThankYouSentNum,");
						}
						sbCommands.Append("ApptSecDateTEntry,DateTimeNewPatThankYouTransmit,PatNum,ClinicNum,SendStatus,MessageType,MessageFk,DateTimeEntry,DateTimeSent,ResponseDescript,ApptReminderRuleNum,ApptNum,ApptDateTime,TSPrior,ShortGUID) VALUES ");
						countRows=0;
					}
					else {
						hasComma=true;
					}
					if(useExistingPK) {
						sbRow.Append(POut.Long(apptNewPatThankYouSent.ApptNewPatThankYouSentNum)); sbRow.Append(",");
					}
					sbRow.Append(POut.DateT(apptNewPatThankYouSent.ApptSecDateTEntry)); sbRow.Append(",");
					sbRow.Append(POut.DateT(apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit)); sbRow.Append(",");
					sbRow.Append(POut.Long(apptNewPatThankYouSent.PatNum)); sbRow.Append(",");
					sbRow.Append(POut.Long(apptNewPatThankYouSent.ClinicNum)); sbRow.Append(",");
					sbRow.Append(POut.Int((int)apptNewPatThankYouSent.SendStatus)); sbRow.Append(",");
					sbRow.Append(POut.Int((int)apptNewPatThankYouSent.MessageType)); sbRow.Append(",");
					sbRow.Append(POut.Long(apptNewPatThankYouSent.MessageFk)); sbRow.Append(",");
					sbRow.Append(DbHelper.Now()); sbRow.Append(",");
					sbRow.Append(POut.DateT(apptNewPatThankYouSent.DateTimeSent)); sbRow.Append(",");
					sbRow.Append("'"+POut.String(apptNewPatThankYouSent.ResponseDescript)+"'"); sbRow.Append(",");
					sbRow.Append(POut.Long(apptNewPatThankYouSent.ApptReminderRuleNum)); sbRow.Append(",");
					sbRow.Append(POut.Long(apptNewPatThankYouSent.ApptNum)); sbRow.Append(",");
					sbRow.Append(POut.DateT(apptNewPatThankYouSent.ApptDateTime)); sbRow.Append(",");
					sbRow.Append("'"+POut.Long  (apptNewPatThankYouSent.TSPrior.Ticks)+"'"); sbRow.Append(",");
					sbRow.Append("'"+POut.String(apptNewPatThankYouSent.ShortGUID)+"'"); sbRow.Append(")");
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
						if(index==listApptNewPatThankYouSents.Count-1) {
							Db.NonQ(sbCommands.ToString());
						}
						index++;
					}
				}
			}
		}

		///<summary>Inserts one ApptNewPatThankYouSent into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ApptNewPatThankYouSent apptNewPatThankYouSent) {
			return InsertNoCache(apptNewPatThankYouSent,false);
		}

		///<summary>Inserts one ApptNewPatThankYouSent into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ApptNewPatThankYouSent apptNewPatThankYouSent,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO apptnewpatthankyousent (";
			if(!useExistingPK && isRandomKeys) {
				apptNewPatThankYouSent.ApptNewPatThankYouSentNum=ReplicationServers.GetKeyNoCache("apptnewpatthankyousent","ApptNewPatThankYouSentNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ApptNewPatThankYouSentNum,";
			}
			command+="ApptSecDateTEntry,DateTimeNewPatThankYouTransmit,PatNum,ClinicNum,SendStatus,MessageType,MessageFk,DateTimeEntry,DateTimeSent,ResponseDescript,ApptReminderRuleNum,ApptNum,ApptDateTime,TSPrior,ShortGUID) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(apptNewPatThankYouSent.ApptNewPatThankYouSentNum)+",";
			}
			command+=
				     POut.DateT (apptNewPatThankYouSent.ApptSecDateTEntry)+","
				+    POut.DateT (apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit)+","
				+    POut.Long  (apptNewPatThankYouSent.PatNum)+","
				+    POut.Long  (apptNewPatThankYouSent.ClinicNum)+","
				+    POut.Int   ((int)apptNewPatThankYouSent.SendStatus)+","
				+    POut.Int   ((int)apptNewPatThankYouSent.MessageType)+","
				+    POut.Long  (apptNewPatThankYouSent.MessageFk)+","
				+    DbHelper.Now()+","
				+    POut.DateT (apptNewPatThankYouSent.DateTimeSent)+","
				+    DbHelper.ParamChar+"paramResponseDescript,"
				+    POut.Long  (apptNewPatThankYouSent.ApptReminderRuleNum)+","
				+    POut.Long  (apptNewPatThankYouSent.ApptNum)+","
				+    POut.DateT (apptNewPatThankYouSent.ApptDateTime)+","
				+"'"+POut.Long(apptNewPatThankYouSent.TSPrior.Ticks)+"',"
				+"'"+POut.String(apptNewPatThankYouSent.ShortGUID)+"')";
			if(apptNewPatThankYouSent.ResponseDescript==null) {
				apptNewPatThankYouSent.ResponseDescript="";
			}
			OdSqlParameter paramResponseDescript=new OdSqlParameter("paramResponseDescript",OdDbType.Text,POut.StringParam(apptNewPatThankYouSent.ResponseDescript));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramResponseDescript);
			}
			else {
				apptNewPatThankYouSent.ApptNewPatThankYouSentNum=Db.NonQ(command,true,"ApptNewPatThankYouSentNum","apptNewPatThankYouSent",paramResponseDescript);
			}
			return apptNewPatThankYouSent.ApptNewPatThankYouSentNum;
		}

		///<summary>Updates one ApptNewPatThankYouSent in the database.</summary>
		public static void Update(ApptNewPatThankYouSent apptNewPatThankYouSent) {
			string command="UPDATE apptnewpatthankyousent SET "
				+"ApptSecDateTEntry             =  "+POut.DateT (apptNewPatThankYouSent.ApptSecDateTEntry)+", "
				+"DateTimeNewPatThankYouTransmit=  "+POut.DateT (apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit)+", "
				+"PatNum                        =  "+POut.Long  (apptNewPatThankYouSent.PatNum)+", "
				+"ClinicNum                     =  "+POut.Long  (apptNewPatThankYouSent.ClinicNum)+", "
				+"SendStatus                    =  "+POut.Int   ((int)apptNewPatThankYouSent.SendStatus)+", "
				+"MessageType                   =  "+POut.Int   ((int)apptNewPatThankYouSent.MessageType)+", "
				+"MessageFk                     =  "+POut.Long  (apptNewPatThankYouSent.MessageFk)+", "
				//DateTimeEntry not allowed to change
				+"DateTimeSent                  =  "+POut.DateT (apptNewPatThankYouSent.DateTimeSent)+", "
				+"ResponseDescript              =  "+DbHelper.ParamChar+"paramResponseDescript, "
				+"ApptReminderRuleNum           =  "+POut.Long  (apptNewPatThankYouSent.ApptReminderRuleNum)+", "
				+"ApptNum                       =  "+POut.Long  (apptNewPatThankYouSent.ApptNum)+", "
				+"ApptDateTime                  =  "+POut.DateT (apptNewPatThankYouSent.ApptDateTime)+", "
				+"TSPrior                       =  "+POut.Long  (apptNewPatThankYouSent.TSPrior.Ticks)+", "
				+"ShortGUID                     = '"+POut.String(apptNewPatThankYouSent.ShortGUID)+"' "
				+"WHERE ApptNewPatThankYouSentNum = "+POut.Long(apptNewPatThankYouSent.ApptNewPatThankYouSentNum);
			if(apptNewPatThankYouSent.ResponseDescript==null) {
				apptNewPatThankYouSent.ResponseDescript="";
			}
			OdSqlParameter paramResponseDescript=new OdSqlParameter("paramResponseDescript",OdDbType.Text,POut.StringParam(apptNewPatThankYouSent.ResponseDescript));
			Db.NonQ(command,paramResponseDescript);
		}

		///<summary>Updates one ApptNewPatThankYouSent in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(ApptNewPatThankYouSent apptNewPatThankYouSent,ApptNewPatThankYouSent oldApptNewPatThankYouSent) {
			string command="";
			if(apptNewPatThankYouSent.ApptSecDateTEntry != oldApptNewPatThankYouSent.ApptSecDateTEntry) {
				if(command!="") { command+=",";}
				command+="ApptSecDateTEntry = "+POut.DateT(apptNewPatThankYouSent.ApptSecDateTEntry)+"";
			}
			if(apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit != oldApptNewPatThankYouSent.DateTimeNewPatThankYouTransmit) {
				if(command!="") { command+=",";}
				command+="DateTimeNewPatThankYouTransmit = "+POut.DateT(apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit)+"";
			}
			if(apptNewPatThankYouSent.PatNum != oldApptNewPatThankYouSent.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(apptNewPatThankYouSent.PatNum)+"";
			}
			if(apptNewPatThankYouSent.ClinicNum != oldApptNewPatThankYouSent.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(apptNewPatThankYouSent.ClinicNum)+"";
			}
			if(apptNewPatThankYouSent.SendStatus != oldApptNewPatThankYouSent.SendStatus) {
				if(command!="") { command+=",";}
				command+="SendStatus = "+POut.Int   ((int)apptNewPatThankYouSent.SendStatus)+"";
			}
			if(apptNewPatThankYouSent.MessageType != oldApptNewPatThankYouSent.MessageType) {
				if(command!="") { command+=",";}
				command+="MessageType = "+POut.Int   ((int)apptNewPatThankYouSent.MessageType)+"";
			}
			if(apptNewPatThankYouSent.MessageFk != oldApptNewPatThankYouSent.MessageFk) {
				if(command!="") { command+=",";}
				command+="MessageFk = "+POut.Long(apptNewPatThankYouSent.MessageFk)+"";
			}
			//DateTimeEntry not allowed to change
			if(apptNewPatThankYouSent.DateTimeSent != oldApptNewPatThankYouSent.DateTimeSent) {
				if(command!="") { command+=",";}
				command+="DateTimeSent = "+POut.DateT(apptNewPatThankYouSent.DateTimeSent)+"";
			}
			if(apptNewPatThankYouSent.ResponseDescript != oldApptNewPatThankYouSent.ResponseDescript) {
				if(command!="") { command+=",";}
				command+="ResponseDescript = "+DbHelper.ParamChar+"paramResponseDescript";
			}
			if(apptNewPatThankYouSent.ApptReminderRuleNum != oldApptNewPatThankYouSent.ApptReminderRuleNum) {
				if(command!="") { command+=",";}
				command+="ApptReminderRuleNum = "+POut.Long(apptNewPatThankYouSent.ApptReminderRuleNum)+"";
			}
			if(apptNewPatThankYouSent.ApptNum != oldApptNewPatThankYouSent.ApptNum) {
				if(command!="") { command+=",";}
				command+="ApptNum = "+POut.Long(apptNewPatThankYouSent.ApptNum)+"";
			}
			if(apptNewPatThankYouSent.ApptDateTime != oldApptNewPatThankYouSent.ApptDateTime) {
				if(command!="") { command+=",";}
				command+="ApptDateTime = "+POut.DateT(apptNewPatThankYouSent.ApptDateTime)+"";
			}
			if(apptNewPatThankYouSent.TSPrior != oldApptNewPatThankYouSent.TSPrior) {
				if(command!="") { command+=",";}
				command+="TSPrior = '"+POut.Long  (apptNewPatThankYouSent.TSPrior.Ticks)+"'";
			}
			if(apptNewPatThankYouSent.ShortGUID != oldApptNewPatThankYouSent.ShortGUID) {
				if(command!="") { command+=",";}
				command+="ShortGUID = '"+POut.String(apptNewPatThankYouSent.ShortGUID)+"'";
			}
			if(command=="") {
				return false;
			}
			if(apptNewPatThankYouSent.ResponseDescript==null) {
				apptNewPatThankYouSent.ResponseDescript="";
			}
			OdSqlParameter paramResponseDescript=new OdSqlParameter("paramResponseDescript",OdDbType.Text,POut.StringParam(apptNewPatThankYouSent.ResponseDescript));
			command="UPDATE apptnewpatthankyousent SET "+command
				+" WHERE ApptNewPatThankYouSentNum = "+POut.Long(apptNewPatThankYouSent.ApptNewPatThankYouSentNum);
			Db.NonQ(command,paramResponseDescript);
			return true;
		}

		///<summary>Returns true if Update(ApptNewPatThankYouSent,ApptNewPatThankYouSent) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(ApptNewPatThankYouSent apptNewPatThankYouSent,ApptNewPatThankYouSent oldApptNewPatThankYouSent) {
			if(apptNewPatThankYouSent.ApptSecDateTEntry != oldApptNewPatThankYouSent.ApptSecDateTEntry) {
				return true;
			}
			if(apptNewPatThankYouSent.DateTimeNewPatThankYouTransmit != oldApptNewPatThankYouSent.DateTimeNewPatThankYouTransmit) {
				return true;
			}
			if(apptNewPatThankYouSent.PatNum != oldApptNewPatThankYouSent.PatNum) {
				return true;
			}
			if(apptNewPatThankYouSent.ClinicNum != oldApptNewPatThankYouSent.ClinicNum) {
				return true;
			}
			if(apptNewPatThankYouSent.SendStatus != oldApptNewPatThankYouSent.SendStatus) {
				return true;
			}
			if(apptNewPatThankYouSent.MessageType != oldApptNewPatThankYouSent.MessageType) {
				return true;
			}
			if(apptNewPatThankYouSent.MessageFk != oldApptNewPatThankYouSent.MessageFk) {
				return true;
			}
			//DateTimeEntry not allowed to change
			if(apptNewPatThankYouSent.DateTimeSent != oldApptNewPatThankYouSent.DateTimeSent) {
				return true;
			}
			if(apptNewPatThankYouSent.ResponseDescript != oldApptNewPatThankYouSent.ResponseDescript) {
				return true;
			}
			if(apptNewPatThankYouSent.ApptReminderRuleNum != oldApptNewPatThankYouSent.ApptReminderRuleNum) {
				return true;
			}
			if(apptNewPatThankYouSent.ApptNum != oldApptNewPatThankYouSent.ApptNum) {
				return true;
			}
			if(apptNewPatThankYouSent.ApptDateTime != oldApptNewPatThankYouSent.ApptDateTime) {
				return true;
			}
			if(apptNewPatThankYouSent.TSPrior != oldApptNewPatThankYouSent.TSPrior) {
				return true;
			}
			if(apptNewPatThankYouSent.ShortGUID != oldApptNewPatThankYouSent.ShortGUID) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one ApptNewPatThankYouSent from the database.</summary>
		public static void Delete(long apptNewPatThankYouSentNum) {
			string command="DELETE FROM apptnewpatthankyousent "
				+"WHERE ApptNewPatThankYouSentNum = "+POut.Long(apptNewPatThankYouSentNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many ApptNewPatThankYouSents from the database.</summary>
		public static void DeleteMany(List<long> listApptNewPatThankYouSentNums) {
			if(listApptNewPatThankYouSentNums==null || listApptNewPatThankYouSentNums.Count==0) {
				return;
			}
			string command="DELETE FROM apptnewpatthankyousent "
				+"WHERE ApptNewPatThankYouSentNum IN("+string.Join(",",listApptNewPatThankYouSentNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}