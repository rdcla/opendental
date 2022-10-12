//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Mobile.Crud{
	internal class UsermCrud {
		///<summary>Gets one Userm object from the database using primaryKey1(CustomerNum) and primaryKey2.  Returns null if not found.</summary>
		internal static Userm SelectOne(long customerNum,long usermNum){
			string command="SELECT * FROM userm "
				+"WHERE CustomerNum = "+POut.Long(customerNum)+" AND UsermNum = "+POut.Long(usermNum);
			List<Userm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Userm object from the database using a query.</summary>
		internal static Userm SelectOne(string command){
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Userm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Userm objects from the database using a query.</summary>
		internal static List<Userm> SelectMany(string command){
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Userm> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		internal static List<Userm> TableToList(DataTable table){
			List<Userm> retVal=new List<Userm>();
			Userm userm;
			for(int i=0;i<table.Rows.Count;i++) {
				userm=new Userm();
				userm.CustomerNum= PIn.Long  (table.Rows[i]["CustomerNum"].ToString());
				userm.UsermNum   = PIn.Long  (table.Rows[i]["UsermNum"].ToString());
				userm.UserName   = PIn.String(table.Rows[i]["UserName"].ToString());
				userm.Password   = PIn.String(table.Rows[i]["Password"].ToString());
				retVal.Add(userm);
			}
			return retVal;
		}

		///<summary>Usually set useExistingPK=true.  Inserts one Userm into the database.</summary>
		internal static long Insert(Userm userm,bool useExistingPK){
			if(!useExistingPK) {
				userm.UsermNum=ReplicationServers.GetKey("userm","UsermNum");
			}
			string command="INSERT INTO userm (";
			command+="UsermNum,";
			command+="CustomerNum,UserName,Password) VALUES(";
			command+=POut.Long(userm.UsermNum)+",";
			command+=
				     POut.Long  (userm.CustomerNum)+","
				+"'"+POut.String(userm.UserName)+"',"
				+"'"+POut.String(userm.Password)+"')";
			Db.NonQ(command);//There is no autoincrement in the mobile server.
			return userm.UsermNum;
		}

		///<summary>Updates one Userm in the database.</summary>
		internal static void Update(Userm userm){
			string command="UPDATE userm SET "
				+"UserName   = '"+POut.String(userm.UserName)+"', "
				+"Password   = '"+POut.String(userm.Password)+"' "
				+"WHERE CustomerNum = "+POut.Long(userm.CustomerNum)+" AND UsermNum = "+POut.Long(userm.UsermNum);
			Db.NonQ(command);
		}

		///<summary>Deletes one Userm from the database.</summary>
		internal static void Delete(long customerNum,long usermNum){
			string command="DELETE FROM userm "
				+"WHERE CustomerNum = "+POut.Long(customerNum)+" AND UsermNum = "+POut.Long(usermNum);
			Db.NonQ(command);
		}

		//ConvertToM not applicable.

	}
}