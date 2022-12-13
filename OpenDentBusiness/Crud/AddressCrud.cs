//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class AddressCrud {
		///<summary>Gets one Address object from the database using the primary key.  Returns null if not found.</summary>
		public static Address SelectOne(long addressNum) {
			string command="SELECT * FROM address "
				+"WHERE AddressNum = "+POut.Long(addressNum);
			List<Address> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Address object from the database using a query.</summary>
		public static Address SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Address> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Address objects from the database using a query.</summary>
		public static List<Address> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Address> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Address> TableToList(DataTable table) {
			List<Address> retVal=new List<Address>();
			Address address;
			foreach(DataRow row in table.Rows) {
				address=new Address();
				address.AddressNum       = PIn.Long  (row["AddressNum"].ToString());
				address.Address1         = PIn.String(row["Address1"].ToString());
				address.Address2         = PIn.String(row["Address2"].ToString());
				address.City             = PIn.String(row["City"].ToString());
				address.State            = PIn.String(row["State"].ToString());
				address.Zip              = PIn.String(row["Zip"].ToString());
				address.PatNumTaxPhysical= PIn.Long  (row["PatNumTaxPhysical"].ToString());
				retVal.Add(address);
			}
			return retVal;
		}

		///<summary>Converts a list of Address into a DataTable.</summary>
		public static DataTable ListToTable(List<Address> listAddresss,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Address";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("AddressNum");
			table.Columns.Add("Address1");
			table.Columns.Add("Address2");
			table.Columns.Add("City");
			table.Columns.Add("State");
			table.Columns.Add("Zip");
			table.Columns.Add("PatNumTaxPhysical");
			foreach(Address address in listAddresss) {
				table.Rows.Add(new object[] {
					POut.Long  (address.AddressNum),
					            address.Address1,
					            address.Address2,
					            address.City,
					            address.State,
					            address.Zip,
					POut.Long  (address.PatNumTaxPhysical),
				});
			}
			return table;
		}

		///<summary>Inserts one Address into the database.  Returns the new priKey.</summary>
		public static long Insert(Address address) {
			return Insert(address,false);
		}

		///<summary>Inserts one Address into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Address address,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				address.AddressNum=ReplicationServers.GetKey("address","AddressNum");
			}
			string command="INSERT INTO address (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="AddressNum,";
			}
			command+="Address1,Address2,City,State,Zip,PatNumTaxPhysical) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(address.AddressNum)+",";
			}
			command+=
				 "'"+POut.String(address.Address1)+"',"
				+"'"+POut.String(address.Address2)+"',"
				+"'"+POut.String(address.City)+"',"
				+"'"+POut.String(address.State)+"',"
				+"'"+POut.String(address.Zip)+"',"
				+    POut.Long  (address.PatNumTaxPhysical)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				address.AddressNum=Db.NonQ(command,true,"AddressNum","address");
			}
			return address.AddressNum;
		}

		///<summary>Inserts one Address into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Address address) {
			return InsertNoCache(address,false);
		}

		///<summary>Inserts one Address into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Address address,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO address (";
			if(!useExistingPK && isRandomKeys) {
				address.AddressNum=ReplicationServers.GetKeyNoCache("address","AddressNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="AddressNum,";
			}
			command+="Address1,Address2,City,State,Zip,PatNumTaxPhysical) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(address.AddressNum)+",";
			}
			command+=
				 "'"+POut.String(address.Address1)+"',"
				+"'"+POut.String(address.Address2)+"',"
				+"'"+POut.String(address.City)+"',"
				+"'"+POut.String(address.State)+"',"
				+"'"+POut.String(address.Zip)+"',"
				+    POut.Long  (address.PatNumTaxPhysical)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				address.AddressNum=Db.NonQ(command,true,"AddressNum","address");
			}
			return address.AddressNum;
		}

		///<summary>Updates one Address in the database.</summary>
		public static void Update(Address address) {
			string command="UPDATE address SET "
				+"Address1         = '"+POut.String(address.Address1)+"', "
				+"Address2         = '"+POut.String(address.Address2)+"', "
				+"City             = '"+POut.String(address.City)+"', "
				+"State            = '"+POut.String(address.State)+"', "
				+"Zip              = '"+POut.String(address.Zip)+"', "
				+"PatNumTaxPhysical=  "+POut.Long  (address.PatNumTaxPhysical)+" "
				+"WHERE AddressNum = "+POut.Long(address.AddressNum);
			Db.NonQ(command);
		}

		///<summary>Updates one Address in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Address address,Address oldAddress) {
			string command="";
			if(address.Address1 != oldAddress.Address1) {
				if(command!="") { command+=",";}
				command+="Address1 = '"+POut.String(address.Address1)+"'";
			}
			if(address.Address2 != oldAddress.Address2) {
				if(command!="") { command+=",";}
				command+="Address2 = '"+POut.String(address.Address2)+"'";
			}
			if(address.City != oldAddress.City) {
				if(command!="") { command+=",";}
				command+="City = '"+POut.String(address.City)+"'";
			}
			if(address.State != oldAddress.State) {
				if(command!="") { command+=",";}
				command+="State = '"+POut.String(address.State)+"'";
			}
			if(address.Zip != oldAddress.Zip) {
				if(command!="") { command+=",";}
				command+="Zip = '"+POut.String(address.Zip)+"'";
			}
			if(address.PatNumTaxPhysical != oldAddress.PatNumTaxPhysical) {
				if(command!="") { command+=",";}
				command+="PatNumTaxPhysical = "+POut.Long(address.PatNumTaxPhysical)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE address SET "+command
				+" WHERE AddressNum = "+POut.Long(address.AddressNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Address,Address) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Address address,Address oldAddress) {
			if(address.Address1 != oldAddress.Address1) {
				return true;
			}
			if(address.Address2 != oldAddress.Address2) {
				return true;
			}
			if(address.City != oldAddress.City) {
				return true;
			}
			if(address.State != oldAddress.State) {
				return true;
			}
			if(address.Zip != oldAddress.Zip) {
				return true;
			}
			if(address.PatNumTaxPhysical != oldAddress.PatNumTaxPhysical) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Address from the database.</summary>
		public static void Delete(long addressNum) {
			string command="DELETE FROM address "
				+"WHERE AddressNum = "+POut.Long(addressNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Addresss from the database.</summary>
		public static void DeleteMany(List<long> listAddressNums) {
			if(listAddressNums==null || listAddressNums.Count==0) {
				return;
			}
			string command="DELETE FROM address "
				+"WHERE AddressNum IN("+string.Join(",",listAddressNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}