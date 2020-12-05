using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team_Repo
{
    public class DevTeamRepository
    {
        private List<DevTeam> _listofteam = new List<DevTeam>();

        //Create
        public void AddContentToList(DevTeam content)
        {
            _listofteam.Add(content);

        }

        //read
        public List<DevTeam> GetContentList()
        {
            return _listofteam;

        }


        //update
        public bool UpdateExistingContent(string origionalTeamMember, DevTeam newContent)
        {
            //Find the content
            DevTeam oldContent = GetContentByName(origionalTeamMember);

            //update the content
            if(oldContent != null)
            {
                oldContent.TeamMember = newContent.TeamMember;
                oldContent.IdNumber = newContent.IdNumber;
                oldContent.PluralSight = newContent.PluralSight;

                return true;
            }
            else
            {
                return false;
            }
        }



        //delete
        public bool RemoveContentFromList(string teamMember)
        {
            DevTeam content = GetContentByName(teamMember);

            if (content == null)
            {
                return false;
            }

            int initialcount = _listofteam.Count;
            _listofteam.Remove(content);

            if (initialcount > _listofteam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //helper method
        public DevTeam GetContentByName(string teamMember)
        {
            foreach(DevTeam content in _listofteam)
            {
                if(content.TeamMember.ToLower() == teamMember)
                {
                    return content;
                }
            }

            return null;
        }


    }
}
