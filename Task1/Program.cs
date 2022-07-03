string s1 = "2";
string s2 = "Dog";
string s3 = "Country";
string s4 = "Warior";
string s5 = "he";

string[] values = new string[] { s1, s2, s3, s4, s5 };
string s_joined = string.Join(" ", values);

Console.Write(s_joined + " -> ");