using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the ROR_R0R_DEFINITION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: QRD (QRD - original-style query definition segment) </li>
///<li>1: QRF (QRF - original style query filter segment) optional </li>
///<li>2: ROR_R0R_PATIENT (a Group object) optional </li>
///<li>3: ROR_R0R_ORDER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class ROR_R0R_DEFINITION : AbstractGroup {

	///<summary> 
	/// Creates a new ROR_R0R_DEFINITION Group.
	///</summary>
	public ROR_R0R_DEFINITION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(ROR_R0R_PATIENT), false, false);
	      this.add(typeof(ROR_R0R_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ROR_R0R_DEFINITION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns QRD (QRD - original-style query definition segment) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRF (QRF - original style query filter segment) - creates it if necessary
	///</summary>
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.GetStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ROR_R0R_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public ROR_R0R_PATIENT PATIENT { 
get{
	   ROR_R0R_PATIENT ret = null;
	   try {
	      ret = (ROR_R0R_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ROR_R0R_ORDER (a Group object) - creates it if necessary
	///</summary>
	public ROR_R0R_ORDER GetORDER() {
	   ROR_R0R_ORDER ret = null;
	   try {
	      ret = (ROR_R0R_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ROR_R0R_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ROR_R0R_ORDER GetORDER(int rep) { 
	   return (ROR_R0R_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ROR_R0R_ORDER 
	 */ 
	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ROR_R0R_ORDER results 
	 */ 
	public IEnumerable<ROR_R0R_ORDER> ORDERs 
	{ 
		get
		{
			for (int rep = 0; rep < ORDERRepetitionsUsed; rep++)
			{
				yield return (ROR_R0R_ORDER)this.GetStructure("ORDER", rep);
			}
		}
	}

	///<summary>
	///Adds a new ROR_R0R_ORDER
	///</summary>
	public ROR_R0R_ORDER AddORDER()
	{
		return this.AddStructure("ORDER") as ROR_R0R_ORDER;
	}

	///<summary>
	///Removes the given ROR_R0R_ORDER
	///</summary>
	public void RemoveORDER(ROR_R0R_ORDER toRemove)
	{
		this.RemoveStructure("ORDER", toRemove);
	}

	///<summary>
	///Removes the ROR_R0R_ORDER at the given index
	///</summary>
	public void RemoveORDERAt(int index)
	{
		this.RemoveRepetition("ORDER", index);
	}

}
}
