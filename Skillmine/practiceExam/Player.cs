using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    public class Player : IComparable
    {

        private string name;
        private int runs;
        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public int CompareTo(object obj)// obj=player4
        {

            Player p4 = (Player)obj;  // type casting
            // to access runs of palyer1 we use this
            // this--> point to the current object
            if (this.runs > p4.runs)
            {
                return 1;
            }
            else if (this.runs < p4.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name} -> {runs}";
        }
    }
    /*public class Team : IEnumerable<Player>
    {
        private Player[] players;
        public Team()
        {
            players = new Player[5];
            players[0] = new Player("Rohit", 45);
            players[1] = new Player("Virat", 80);
            players[2] = new Player("Ishan", 79);
            players[3] = new Player("Ashwin", 33);
            players[4] = new Player("Hardik", 88);
        }*/

        /*public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }*/
    }

    public class Program11
    {
        /*
                static void Main(string[] args)
                {
                    Team team = new Team();
                    foreach (Player p in team)
                    {
                        Console.WriteLine(p);
                    }

                    Player players1 = new Player("Rohit", 53);
                    Player players2 = new Player("Virat", 80);
                    Player players3 = new Player("Ishan", 79);
                    Player players4 = new Player("Ashwin", 53);
                    Player players5 = new Player("Hardik", 88);

                    int result = players1.CompareTo(players4);
                    if (result == 1)
                    {
                        Console.WriteLine("rohit has more runs than ashwin");
                    }
                    else if (result == -1)
                    {
                        Console.WriteLine("rohit has less runs than ashwin");
                    }
                    else
                    {
                        Console.WriteLine("rohit & ashwin has same score");
                    }
                }


            }
          public class Check : IComparer  
            {
                public int Compare(object x, object y)
                {
                    Player p1 = (Player)x;
                    Player p4 = (Player)y;
                    if (p1.Runs > p4.Runs)
                    {
                        return 1;
                    }
                    else if (p1.Runs < p4.Runs)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }

            }*/
    }

