﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Gabriel_DBEntities : DbContext
    {
        public Gabriel_DBEntities()
            : base("name=Gabriel_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Law_Classification> Law_Classification { get; set; }
        public virtual DbSet<Law_Recording_Classification> Law_Recording_Classification { get; set; }
        public virtual DbSet<Model_Catalog> Model_Catalog { get; set; }
    

    
        public virtual ObjectResult<SwarmUpdateStatus_Result> SwarmUpdateStatus(string swarmID, string status, string results, string winner)
        {
            var swarmIDParameter = swarmID != null ?
                new ObjectParameter("SwarmID", swarmID) :
                new ObjectParameter("SwarmID", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            var resultsParameter = results != null ?
                new ObjectParameter("Results", results) :
                new ObjectParameter("Results", typeof(string));
    
            var winnerParameter = winner != null ?
                new ObjectParameter("Winner", winner) :
                new ObjectParameter("Winner", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SwarmUpdateStatus_Result>("SwarmUpdateStatus", swarmIDParameter, statusParameter, resultsParameter, winnerParameter);
        }
    

        public virtual ObjectResult<GetPlayedSwarmsList_Result> GetPlayedSwarmsList(string swarmType, Nullable<int> startRow, Nullable<int> numberofRows)
        {
            var swarmTypeParameter = swarmType != null ?
                new ObjectParameter("SwarmType", swarmType) :
                new ObjectParameter("SwarmType", typeof(string));
    
            var startRowParameter = startRow.HasValue ?
                new ObjectParameter("StartRow", startRow) :
                new ObjectParameter("StartRow", typeof(int));
    
            var numberofRowsParameter = numberofRows.HasValue ?
                new ObjectParameter("NumberofRows", numberofRows) :
                new ObjectParameter("NumberofRows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPlayedSwarmsList_Result>("GetPlayedSwarmsList1", swarmTypeParameter, startRowParameter, numberofRowsParameter);
        }
    
        public virtual ObjectResult<GetAvailableSwarms_Result> GetAvailableSwarms(string swarmType, Nullable<int> startRow, Nullable<int> numberofRows)
        {
            var swarmTypeParameter = swarmType != null ?
                new ObjectParameter("SwarmType", swarmType) :
                new ObjectParameter("SwarmType", typeof(string));
    
            var startRowParameter = startRow.HasValue ?
                new ObjectParameter("StartRow", startRow) :
                new ObjectParameter("StartRow", typeof(int));
    
            var numberofRowsParameter = numberofRows.HasValue ?
                new ObjectParameter("NumberofRows", numberofRows) :
                new ObjectParameter("NumberofRows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAvailableSwarms_Result>("GetAvailableSwarms1", swarmTypeParameter, startRowParameter, numberofRowsParameter);
        }
    
        public virtual ObjectResult<GetPlayedSwarmData_Result> GetPlayedSwarmData(string swarmID)
        {
            var swarmIDParameter = swarmID != null ?
                new ObjectParameter("SwarmID", swarmID) :
                new ObjectParameter("SwarmID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPlayedSwarmData_Result>("GetPlayedSwarmData1", swarmIDParameter);
        }
    
        public virtual ObjectResult<GetSwarmData_Result> GetSwarmData(string swarmID)
        {
            var swarmIDParameter = swarmID != null ?
                new ObjectParameter("SwarmID", swarmID) :
                new ObjectParameter("SwarmID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSwarmData_Result>("GetSwarmData1", swarmIDParameter);
        }
    
        public virtual ObjectResult<PutSwarmURL_Result> PutSwarmURL(string roboCallnumber, string filename, string type, string text, string audioUrl, string videoUrl, string passiveClassifier, Nullable<bool> isTest, string testNotes, Nullable<System.Guid> gabrield)
        {
            var roboCallnumberParameter = roboCallnumber != null ?
                new ObjectParameter("RoboCallnumber", roboCallnumber) :
                new ObjectParameter("RoboCallnumber", typeof(string));
    
            var filenameParameter = filename != null ?
                new ObjectParameter("filename", filename) :
                new ObjectParameter("filename", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("Text", text) :
                new ObjectParameter("Text", typeof(string));
    
            var audioUrlParameter = audioUrl != null ?
                new ObjectParameter("AudioUrl", audioUrl) :
                new ObjectParameter("AudioUrl", typeof(string));
    
            var videoUrlParameter = videoUrl != null ?
                new ObjectParameter("VideoUrl", videoUrl) :
                new ObjectParameter("VideoUrl", typeof(string));
    
            var passiveClassifierParameter = passiveClassifier != null ?
                new ObjectParameter("PassiveClassifier", passiveClassifier) :
                new ObjectParameter("PassiveClassifier", typeof(string));
    
            var isTestParameter = isTest.HasValue ?
                new ObjectParameter("IsTest", isTest) :
                new ObjectParameter("IsTest", typeof(bool));
    
            var testNotesParameter = testNotes != null ?
                new ObjectParameter("TestNotes", testNotes) :
                new ObjectParameter("TestNotes", typeof(string));
    
            var gabrieldParameter = gabrield.HasValue ?
                new ObjectParameter("Gabrield", gabrield) :
                new ObjectParameter("Gabrield", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PutSwarmURL_Result>("PutSwarmURL1", roboCallnumberParameter, filenameParameter, typeParameter, textParameter, audioUrlParameter, videoUrlParameter, passiveClassifierParameter, isTestParameter, testNotesParameter, gabrieldParameter);
        }
    }
}
