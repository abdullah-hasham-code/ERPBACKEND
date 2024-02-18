using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace Backend.Controllers
{
    [ApiController]
    [EnableCors("AllowCors"), Route("[controller]")]
    public class PartyController : Controller
    {
        ERPContext bMSContext = new ERPContext();
        [HttpGet]
        [Route("/api/getAllArea")]
        public IEnumerable<Area> getAllArea()
        {
            return bMSContext.Area.ToList();
        }
        [HttpGet]
        [Route("/api/getAllCity")]
        public IEnumerable<City> getAllCity()
        {
            return bMSContext.City.ToList();
        }
        [HttpGet]
        [Route("/api/getAllSubArea")]
        public IEnumerable<SubArea> getAllSubArea()
        {
            return bMSContext.SubArea.ToList();
        }
        [HttpGet]
        [Route("/api/getAllParty")]
        public IEnumerable<Party> getAllParty()
        {
            return bMSContext.Party.ToList();
        }
        [HttpPost]
        [Route("/api/createParty")]
        public object createParty(Party par)
        {

            try
            {
                try
                {
                    var partyCheck = bMSContext.Party.SingleOrDefault(u => u.Id == par.Id);
                    if (partyCheck != null)
                    {
                        partyCheck.PartyName = par.PartyName;
                        partyCheck.MobileNo = par.MobileNo;
                        partyCheck.Address = par.Address;
                        partyCheck.TelPhoneNo = par.TelPhoneNo;
                        partyCheck.FaxNo = par.FaxNo;
                        partyCheck.Email = par.Email;
                        partyCheck.TaxRegNo = par.TaxRegNo;
                        partyCheck.Ntn = par.Ntn;
                        partyCheck.Nic = par.Nic;
                        partyCheck.AreaId = par.AreaId;
                        partyCheck.CityId = par.CityId;
                        partyCheck.SubAreaId = par.SubAreaId;
                        partyCheck.Address1 = par.Address1;
                        partyCheck.ContactPerson = par.ContactPerson;
                        partyCheck.CategoryId = par.CategoryId;
                        partyCheck.DueDays = par.DueDays;   
                        bMSContext.Party.Update(partyCheck);
                        bMSContext.SaveChanges();
                        return JsonConvert.SerializeObject(new { id = partyCheck.Id });
                    }
                    else
                    {
                        Party newParty = new Party();
                        newParty.PartyName = par.PartyName;
                        newParty.MobileNo = par.MobileNo;
                        newParty.Address = par.Address;
                        newParty.TelPhoneNo = par.TelPhoneNo;
                        newParty.FaxNo = par.FaxNo;
                        newParty.Email = par.Email;
                        newParty.TaxRegNo = par.TaxRegNo;
                        newParty.Ntn = par.Ntn;
                        newParty.Nic = par.Nic;
                        newParty.AreaId = par.AreaId;
                        newParty.CityId = par.CityId;
                        newParty.SubAreaId = par.SubAreaId;
                        newParty.Address1 = par.Address1;
                        newParty.ContactPerson = par.ContactPerson;
                        newParty.CategoryId = par.CategoryId;
                        newParty.DueDays = par.DueDays; 
                        bMSContext.Party.Add(newParty);
                        bMSContext.SaveChanges();
                        return JsonConvert.SerializeObject(new { id = newParty.Id });
                    }
                }

                catch (Exception ex)
                {
                    JsonConvert.SerializeObject(new { msg = ex.Message });
                }
                return JsonConvert.SerializeObject(new { msg = "Message" });
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpGet]
        [Route("/api/deletePartyById")]
        public object deletePartyById(int id)
        {
            try
            {
                var rnt = bMSContext.Party.SingleOrDefault(u => u.Id == id);
                if (rnt != null)
                {
                    bMSContext.Party.Remove(rnt);
                    bMSContext.SaveChanges();
                    return JsonConvert.SerializeObject(new { id = rnt.Id });
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        [HttpGet]
        [Route("/api/getRPartyById")]
        public IEnumerable<Party> getPartyById(int id)
        {
            return bMSContext.Party.Where(u => u.Id == id).ToList();
        }
    }
}
