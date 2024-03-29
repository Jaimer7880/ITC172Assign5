﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Donation
{
    public int DonationKey { get; set; }
    public System.DateTime DonationDate { get; set; }
    public decimal DonationAmount { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public Nullable<int> EmployeeKey { get; set; }
    public Nullable<System.DateTime> DonationConfirmDate { get; set; }

    public virtual Person Person { get; set; }
}

public partial class Person
{
    public Person()
    {
        this.Donations = new HashSet<Donation>();
        this.ServiceGrants = new HashSet<ServiceGrant>();
    }

    public int PersonKey { get; set; }
    public string PersonLastName { get; set; }
    public string PersonFirstName { get; set; }
    public string PersonUsername { get; set; }
    public string PersonPlainPassword { get; set; }
    public Nullable<int> Personpasskey { get; set; }
    public Nullable<System.DateTime> PersonEntryDate { get; set; }
    public byte[] PersonUserPassword { get; set; }

    public virtual ICollection<Donation> Donations { get; set; }
    public virtual ICollection<ServiceGrant> ServiceGrants { get; set; }
}

public partial class ServiceGrant
{
    public int GrantKey { get; set; }
    public Nullable<decimal> GrantAmount { get; set; }
    public Nullable<System.DateTime> GrantDate { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public Nullable<int> ServiceKey { get; set; }
    public Nullable<int> EmployeeKey { get; set; }
    public Nullable<System.DateTime> GrantReviewDate { get; set; }
    public string GrantApprovalStatus { get; set; }
    public string GrantNeedExplanation { get; set; }
    public Nullable<decimal> GrantAllocation { get; set; }

    public virtual Person Person { get; set; }
}
