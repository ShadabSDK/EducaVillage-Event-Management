using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EventManagement.Data
{
    public class EventDataAccess
    {
        public IEnumerable<Event> GetEvents()
        {
            List<Event> events = null;

            DataAccess dbAccess = new DataAccess();
            DataTable eventTable= dbAccess.ExecuteSelectCommand("GetEvents", System.Data.CommandType.StoredProcedure);

            if(eventTable!=null && eventTable.Rows.Count>0)
            {
                events = new List<Event>();

                foreach(DataRow  row in eventTable.Rows)
                {
                    Event eventObj = new Event();
                    eventObj.Id = (int)row["Id"];
                    eventObj.Title = row["Title"].ToString();
                    eventObj.EventDate = (DateTime)row["EventDate"];
                    eventObj.EventTime = (DateTime)row["EventTime"];
                    eventObj.Location = (String)row["Location"];
                    eventObj.Message = (String)row["Message"];
                    eventObj.EventTypeId = (int)row["EventTypeId"];
                    eventObj.CreatedDate = (DateTime)row["CreatedDate"];

                    EventType obj = new EventType();
                    obj.Id= (int)row["Id"];
                    obj.Name = (String)row["Name"];
                    obj.Description = (String)row["Description"];
                    obj.CreatedDate = (DateTime)row["CreatedDate"];

                    eventObj.EventType = obj;




                    events.Add(eventObj);

                }



            }


            return events;
        }
    }
}
