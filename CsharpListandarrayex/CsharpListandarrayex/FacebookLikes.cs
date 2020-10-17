using System.Collections.Generic;

namespace CsharpListandarrayex
{
    public class FacebookLikes
    {
        public List<string> likes = new List<string>();

        public void UserLikes(string name)
        {
            likes.Add(name);
        }
        public int GetLikes()
        {
            return likes.Count;
        }
    }
}
