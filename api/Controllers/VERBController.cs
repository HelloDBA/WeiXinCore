using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeiXinCore.Data;
using WeiXinCore.Models;
using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WeiXinCore.api.Controllers
{
    [Route("api/[controller]")]
    public class VERBController : Controller
    {
        private AppDbContext _context;
        public VERBController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet("{memberID}")]
        public string Get(string memberID, [FromQuery] string signature, string timestamp, string nonce, string echostr)
        {
            VERB verb = new VERB();
            verb = _context.VERB.FirstOrDefault(o=>o.memberID==memberID);
            string _rtstr = Guid.NewGuid().ToString().Replace("-","");

            if (verb != null)
            {
                string token = verb.Token;
                if (CheckSignature(token, signature, timestamp, nonce))
                {
                    _rtstr = echostr;
                }
            }
            return _rtstr;
            //return new string[] { "value1", "value2" };
        }

        private bool CheckSignature(string token, string signature, string timestamp, string nonce)
        {
            string[] ArrTmp = { token, timestamp, nonce };

            Array.Sort(ArrTmp);
            string tmpStr = string.Join("", ArrTmp);

            tmpStr= BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(tmpStr))).Replace("-", "").ToLower();
            
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
