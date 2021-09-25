using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Model;

namespace WebApiDemo.Repos
{
    public interface IAdDetail
    {
        List<AdInfo> getAllAds();
        AdInfo getAdDetail(Int32 adid);
    }

    public class AdDetailRepository : IAdDetail
    {
        List<AdInfo> _adsList = new List<AdInfo> {
        new AdInfo{ AdId = 1, AdTitle = "2 bhk individual house for sale", Location = "Adyar", City= "Chennai" },
        new AdInfo{ AdId = 2, AdTitle = "3 bhk individual house", Location = "Avadi", City= "Chennai" },
        new AdInfo{ AdId = 3, AdTitle = "4 bhk individual house", Location = "Porur", City= "Chennai" },
        new AdInfo{ AdId = 4, AdTitle = "2 bhk Apartments flats", Location = "Adyar", City= "Chennai" },
        new AdInfo{ AdId = 5, Location = "Avadi", City= "Chennai" },
        new AdInfo{ AdTitle = "3 bhk Apartments flats", Location = "Avadi", City= "Chennai" }
        };
        

        List<AdInfo> IAdDetail.getAllAds()
        {
            //Tuple<int, string, AdInfo, string> _tup = new Tuple<int, string, AdInfo, string>(1, "", new AdInfo(), "");
            //var x = Tuple.Create(1, "", new AdInfo(), "");
            return _adsList;
        }



        AdInfo IAdDetail.getAdDetail(int adid)
        {
            adCustomer _cust = new adCustomer { custName = "Kumar", mobile = "" };
            //_cust.custName = "Prem";
            adCustomer _newCust = _cust with { custName = "Prem" };

            return _adsList.FirstOrDefault(x => x.AdId == adid);
        }
    }
}
