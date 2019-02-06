using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInVSSApp
{
    class Finder
    {
        VSS vss;

        public Finder()
        {
            vss = new VSS(Properties.Settings.Default.vssBase, Environment.UserName);
        }        

        public IEnumerable<string> GetRoots()
        {
            return Properties.Settings.Default.roots.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public string FindOne(string pattern, int depth)
        {
            IEnumerable<string> roots = GetRoots();
            string match = "";
            foreach (string root in roots)
            {
                try
                {
                    return vss.FirstInEntireBase(root, ref match, new System.Text.RegularExpressions.Regex(pattern), depth);
                }
                catch { }
            }
            throw new Exception("Файл не найден");
        }

        public IEnumerable<string> FindMany(string pattern, int depth)
        {
            IEnumerable<string> roots = GetRoots();
            foreach (string root in roots)
            {
                List<string> matches = new List<string>();
                foreach (string match in vss.AllInEntireBase(root, matches, new System.Text.RegularExpressions.Regex(pattern), depth))
                {
                    yield return match;
                }
            }
        }

    }
}
