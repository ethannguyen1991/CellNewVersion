﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


public partial class Account
{

    public int AccountId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<bool> IsAllowEdit { get; set; }

    public Nullable<bool> IsActive { get; set; }

    public Nullable<bool> IsAdmin { get; set; }

}


public partial class Comment
{

    public int CommentID { get; set; }

    public int ScenarioID { get; set; }

    public Nullable<int> ContentID { get; set; }

    public int StudentID { get; set; }

    public System.DateTime CreatedOn { get; set; }

    public bool IsActive { get; set; }

    public string Comments { get; set; }

    public string Grade { get; set; }

}


public partial class Content
{

    public int ContentID { get; set; }

    public string HeadingID { get; set; }

    public string HeadingText { get; set; }

    public string Contents { get; set; }

    public string Image { get; set; }

    public bool HasCommentBox { get; set; }

    public bool HasButtons { get; set; }

    public string Link1Caption { get; set; }

    public string Link1Description { get; set; }

    public string Link2Caption { get; set; }

    public string Link2Description { get; set; }

    public string Link3Caption { get; set; }

    public string Link3Description { get; set; }

    public string Link4Caption { get; set; }

    public string Link4Description { get; set; }

    public string Link5Caption { get; set; }

    public string Link5Description { get; set; }

    public string Link6Caption { get; set; }

    public string Link6Description { get; set; }

    public bool IsCreatedByStudent { get; set; }

    public int CreatedBy { get; set; }

    public System.DateTime CreatedOn { get; set; }

    public bool IsActive { get; set; }

}


public partial class Elective
{

    public int electiveId { get; set; }

    public Nullable<int> ScenarioId { get; set; }

    public string text { get; set; }

}


public partial class Scenario
{

    public int ScenarioID { get; set; }

    public string Name { get; set; }

    public string Welcome { get; set; }

    public string LearnAbout { get; set; }

    public string Desciption { get; set; }

    public string Details { get; set; }

    public string Rank { get; set; }

    public string Image { get; set; }

    public bool IsCreatedByStudent { get; set; }

    public int CreatedBy { get; set; }

    public System.DateTime CreatedOn { get; set; }

    public bool IsActive { get; set; }

}


public partial class ScenarioContent
{

    public int ScenarioContentID { get; set; }

    public int ScenarioID { get; set; }

    public int ContentID { get; set; }

    public bool IsActive { get; set; }

}


public partial class SubContent
{

    public int SubContentID { get; set; }

    public int ParentID { get; set; }

    public int ChildID { get; set; }

    public bool IsActive { get; set; }

}
