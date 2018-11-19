using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2Test
{
    class Activity
    {
        String processId;
        String processDesc;
        String processActivity;
        String processSequenceGroup;
        String processPrereqGroup;

        public Activity(ArrayList arrayActivityList)
        {
            this.processId = arrayActivityList[0].ToString();
        }
    }
}
