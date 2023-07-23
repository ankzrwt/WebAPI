using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Runtime.Versioning;
using System.Collections;
using System.Text;

namespace project1.Controllers
{
    [ApiController]

    public class GetController : ControllerBase
    {
        [HttpGet]
        [Route("/print/{a}/{b}")]
        public int[] print(int a, int b) {
            int[] arr = new int[b - a+1];
            int idx = 0;
            for (int i = a; i <= b; i++)
            {
                arr[idx] = i;
                idx += 1;
            }
            return arr;
        
        }


        [HttpGet]
        [Route("/printList/{a}/{b}")]
        public List<int> printList(int a, int b)
        {
            List<int> arr = new List<int>();
            for (int i = a; i <= b; i++)
            {
                arr.Add(i);
            }
            return arr;

        }

        [HttpGet]
        [Route("GetWords/{s}")]
        public List<string> GetWords(string s)
        {
            List<string> str = new List<string>();
            string word = "";
            foreach (char c in s) {

                if (c!= ' ')
                {
                    word += c;

                }
                else {
                    str.Add(word);
                    word = "";
                      }
            }
            str.Add(word);
            return str;
        }


        [HttpGet]
        [Route("/getWordsSplit/{s}")]
        public string[] getWordsSplit(string s) {
            string[] str = s.Split(' ');
            return str;
        }
        [HttpGet]
        [Route("Reverse/{s}")]
        public string Reverse(string s)
        {
            string str = "";
            for (int i = s.Length-1; i >= 0; i--) {
                str += s[i];
            }
            return str;
        }
    }

}

