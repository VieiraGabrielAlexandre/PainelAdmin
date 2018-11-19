using System;
using System.Collections;
using System.Windows.Forms;

namespace DB2Test
{
    class Batch
    {
        public String batchId;
        public String batchProductId;
        public String batchProductDesc;
        public String batchStatus;
        public String batchProductUOM;
        public String batchDepartmentId;
        public String batchLineId;
        public String batchScheduleDate;
        public String batchExpireDate;

        public Batch(ArrayList arrayBatchList) /* Atribui valores de array ao modelo e remove caracteres em branco do STATUS */
        {
            try
            {
                this.batchId = arrayBatchList[0].ToString().Trim();
                this.batchProductId = arrayBatchList[1].ToString().Trim();
                this.batchProductDesc = arrayBatchList[2].ToString().Trim();
                this.batchStatus = arrayBatchList[3].ToString().Trim();
                this.batchProductUOM = arrayBatchList[4].ToString().Trim();
                this.batchDepartmentId = arrayBatchList[5].ToString().Trim();
                this.batchLineId = arrayBatchList[6].ToString().Trim();
                this.batchScheduleDate = arrayBatchList[7].ToString().Trim();
                this.batchExpireDate = arrayBatchList[8].ToString().Trim();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
