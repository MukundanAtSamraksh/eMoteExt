using System;
using System.Threading;
using Microsoft.SPOT;
using CMSIS;

namespace MathFuncsTest
{
    public class Program
    {
        public static void Main()
        {
            Thread.Sleep(5000);

            /*Convert sample radar values (interpreted as fixed) to floats*/
            int val1 = 2063;
            int val2 = 1954;
            int val3 = 1949;

            Debug.Print("Q15 " + val1 + " in floating is: " + Support.ScaleConvertQ15ToFloat(val1, GlobalVar.largeFactor));
            Debug.Print("Q15 " + val2 + " in floating is: " + Support.ScaleConvertQ15ToFloat(val2, GlobalVar.largeFactor));
            Debug.Print("Q15 " + val3 + " in floating is: " + Support.ScaleConvertQ15ToFloat(val3, GlobalVar.largeFactor));

            
           /*Matrix initialization*/
            float[] floatarr1 = new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f };
            float[] floatarr2 = new float[] { 7.0f, 8.0f, 9.0f, 10.0f, 11.0f, 12.0f };
            float[] floatarr3 = new float[] { 8.0f, 7.0f, 6.0f, 5.0f, 4.0f, 3.0f };

            Matrix M1 = new Matrix(2, 3, floatarr1);
            Matrix M2 = new Matrix(3, 2, floatarr2);
            Matrix M3 = new Matrix(2, 3, floatarr3);

            /*Matrix multiplication*/
            Debug.Print("############");
            Debug.Print("# MATRIX 1 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M1.GetRows() + "; cols: " + M1.GetCols() + "; data:");
            foreach (var item in M1.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("############");
            Debug.Print("# MATRIX 2 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M2.GetRows() + "; cols: " + M2.GetCols() + "; data:");
            foreach (var item in M2.GetData())
            {
                Debug.Print(item.ToString());
            }

            Matrix outmat = MatrixFuncs.MatrixMult(M1, M2);

            Debug.Print("################################");
            Debug.Print("# MATRIX MULTIPLICATION OUTPUT #");
            Debug.Print("################################");

            Debug.Print("Out rows: " + outmat.GetRows() + "; cols: " + outmat.GetCols() + "; data:");
            foreach (float item in outmat.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Matrix addition*/
            Debug.Print("############");
            Debug.Print("# MATRIX 1 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M1.GetRows() + "; cols: " + M1.GetCols() + "; data:");
            foreach (var item in M1.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("############");
            Debug.Print("# MATRIX 3 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M3.GetRows() + "; cols: " + M3.GetCols() + "; data:");
            foreach (var item in M3.GetData())
            {
                Debug.Print(item.ToString());
            }

            outmat = MatrixFuncs.MatrixAdd(M1, M3);

            Debug.Print("##########################");
            Debug.Print("# MATRIX ADDITION OUTPUT #");
            Debug.Print("##########################");

            Debug.Print("Out rows: " + outmat.GetRows() + "; cols: " + outmat.GetCols() + "; data:");
            foreach (float item in outmat.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Matrix subtraction*/
            outmat = MatrixFuncs.MatrixSub(M1, M3);

            Debug.Print("#############################");
            Debug.Print("# MATRIX SUBTRACTION OUTPUT #");
            Debug.Print("#############################");

            Debug.Print("Out rows: " + outmat.GetRows() + "; cols: " + outmat.GetCols() + "; data:");
            foreach (float item in outmat.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Matrix transpose*/
            Debug.Print("############");
            Debug.Print("# MATRIX 1 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M1.GetRows() + "; cols: " + M1.GetCols() + "; data:");
            foreach (var item in M1.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("######################");
            Debug.Print("# MATRIX 1 TRANSPOSE #");
            Debug.Print("######################");

            outmat = MatrixFuncs.MatrixTrans(M1);

            Debug.Print("Out rows: " + outmat.GetRows() + "; cols: " + outmat.GetCols() + "; data:");
            foreach (float item in outmat.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("############");
            Debug.Print("# MATRIX 2 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M2.GetRows() + "; cols: " + M2.GetCols() + "; data:");
            foreach (var item in M2.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("######################");
            Debug.Print("# MATRIX 2 TRANSPOSE #");
            Debug.Print("######################");

            outmat = MatrixFuncs.MatrixTrans(M2);

            Debug.Print("Out rows: " + outmat.GetRows() + "; cols: " + outmat.GetCols() + "; data:");
            foreach (float item in outmat.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("############");
            Debug.Print("# MATRIX 3 #");
            Debug.Print("############");

            Debug.Print("Rows: " + M3.GetRows() + "; cols: " + M3.GetCols() + "; data:");
            foreach (var item in M3.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("######################");
            Debug.Print("# MATRIX 3 TRANSPOSE #");
            Debug.Print("######################");

            outmat = MatrixFuncs.MatrixTrans(M3);

            Debug.Print("Out rows: " + outmat.GetRows() + "; cols: " + outmat.GetCols() + "; data:");
            foreach (float item in outmat.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector copy*/
            Debug.Print("############");
            Debug.Print("# VECTOR 0 #");
            Debug.Print("############");

            Debug.Print("Data:");
            foreach (var item in floatarr1)
            {
                Debug.Print(item.ToString());

            }

            float[] copyarr1 = Support.VectorCopy(floatarr1, 0, (uint)floatarr1.Length);

            Debug.Print("#################");
            Debug.Print("# VECTOR 0 COPY #");
            Debug.Print("#################");

            Debug.Print("Data:");
            foreach (var item in copyarr1)
            {
                Debug.Print(item.ToString());
            }

            float[] copyarr2 = Support.VectorCopy(floatarr1, 2, 3);

            Debug.Print("#########################");
            Debug.Print("# VECTOR 0 PARTIAL COPY #");
            Debug.Print("#########################");

            Debug.Print("Data:");
            foreach (var item in copyarr2)
            {
                Debug.Print(item.ToString());
            }

            float scal1 = 3.5f;

            /*Vector fill with scalar */
            Debug.Print("############");
            Debug.Print("# SCALAR 1 #");
            Debug.Print("############");

            Debug.Print("Value:" +scal1 );

            float[] fillarr1 = Support.VectorFill(6, scal1);
            Debug.Print("#############################");
            Debug.Print("# VECTOR FILL WITH SCALAR 1 #");
            Debug.Print("#############################");

            Debug.Print("Vector length: " + fillarr1.Length + "; data:");
            foreach (var item in fillarr1)
            {
                Debug.Print(item.ToString());

            }

            /*Vector definitions*/
            float[] vec1dat = new float[] { 1.0200f, 2.0400f, 6.0900f, -3.1200f, 9.3300f };
            float[] vec2dat = new float[] { -12.1100f, 2.4500f, 6.6000f, 4.5000f, -3.2200f };

            Vector vec1 = new Vector(vec1dat);
            Vector vec2 = new Vector(vec2dat);

            /*Vector absolute*/
            Debug.Print("############");
            Debug.Print("# VECTOR 1 #");
            Debug.Print("############");

            Debug.Print("Data:");
            foreach (var item in vec1.GetData())
            {
                Debug.Print(item.ToString());
            }

            Vector vec1abs = VectorFuncs.VectorAbs(vec1);

            Debug.Print("################");
            Debug.Print("# VECTOR 1 ABS #");
            Debug.Print("################");

            Debug.Print("Data:");
            foreach (var item in vec1abs.GetData())
            {
                Debug.Print(item.ToString());

            }

            /*Vector negative*/
            Vector vec1neg = VectorFuncs.VectorNegate(vec1);

            Debug.Print("################");
            Debug.Print("# VECTOR 1 NEG #");
            Debug.Print("################");

            Debug.Print("Data:");
            foreach (var item in vec1neg.GetData())
            {
                Debug.Print(item.ToString());

            }

            /*Vector offset*/
            Vector vec1offset = VectorFuncs.VectorOffset(vec1, scal1);

            Debug.Print("###################");
            Debug.Print("# VECTOR 1 OFFSET #");
            Debug.Print("###################");
            Debug.Print("Scalar: " + scal1);

            Debug.Print("Data:");
            foreach (var item in vec1offset.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector addition*/
            Debug.Print("############");
            Debug.Print("# VECTOR 1 #");
            Debug.Print("############");

            Debug.Print("Data:");
            foreach (var item in vec1.GetData())
            {
                Debug.Print(item.ToString());
            }

            Debug.Print("############");
            Debug.Print("# VECTOR 2 #");
            Debug.Print("############");

            Debug.Print("Data:");
            foreach (var item in vec2.GetData())
            {
                Debug.Print(item.ToString());
            }

            Vector vecadd = VectorFuncs.VectorAdd(vec1, vec2);

            Debug.Print("##############");
            Debug.Print("# VECTOR ADD #");
            Debug.Print("##############");

            Debug.Print("Data:");
            foreach (var item in vecadd.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector subtraction*/
            Vector vecsub = VectorFuncs.VectorSub(vec1, vec2);

            Debug.Print("##############");
            Debug.Print("# VECTOR SUB #");
            Debug.Print("##############");

            Debug.Print("Data:");
            foreach (var item in vecsub.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector Hadamard product*/
            Vector vecprod = VectorFuncs.VectorHadamard(vec1, vec2);

            Debug.Print("###########################");
            Debug.Print("# VECTOR HADAMARD PRODUCT #");
            Debug.Print("###########################");

            Debug.Print("Data:");
            foreach (var item in vecprod.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector dot product*/
            float vecdot = VectorFuncs.VectorDot(vec1, vec2);

            Debug.Print("######################");
            Debug.Print("# VECTOR DOT PRODUCT #");
            Debug.Print("######################");

            Debug.Print("Value:" + vecdot);

            /*Vector reciprocal*/
            Vector vec1recip = VectorFuncs.VectorRecip(vec1);

            Debug.Print("#######################");
            Debug.Print("# VECTOR 1 RECIPROCAL #");
            Debug.Print("#######################");
            foreach (var item in vec1recip.GetData())
            {
                Debug.Print(item.ToString());
            }

            Vector vec2recip = VectorFuncs.VectorRecip(vec2);

            Debug.Print("#######################");
            Debug.Print("# VECTOR 2 RECIPROCAL #");
            Debug.Print("#######################");
            foreach (var item in vec2recip.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector scaling*/
            Vector vec1sc = VectorFuncs.VectorScale(vec1, scal1);

            Debug.Print("##########################");
            Debug.Print("# VECTOR 1 SCALED BY 3.5 #");
            Debug.Print("##########################");
            foreach (var item in vec1sc.GetData())
            {
                Debug.Print(item.ToString());
            }

            Vector vec2sc = VectorFuncs.VectorScale(vec2, scal1);

            Debug.Print("##########################");
            Debug.Print("# VECTOR 2 SCALED BY 3.5 #");
            Debug.Print("##########################");
            foreach (var item in vec2sc.GetData())
            {
                Debug.Print(item.ToString());
            }

            /*Vector statistics*/
            Debug.Print("#######################");
            Debug.Print("# VECTOR 1 STATISTICS #");
            Debug.Print("#######################");

            Debug.Print("Data:");
            foreach (var item in vec1.GetData())
            {
                Debug.Print(item.ToString());
            }

            UInt32 maxIndex, minIndex;
            float max = Stats.Max(vec1.GetData(), out maxIndex);
            float min = Stats.Min(vec1.GetData(), out minIndex);
            Debug.Print("Max: " + max + " at index: " + maxIndex);
            Debug.Print("Min: " + min + " at index: " + minIndex);
            Debug.Print("Mean: " + Stats.Mean(vec1.GetData()));
            Debug.Print("Standard deviation: " + Stats.StD(vec1.GetData()));
            Debug.Print("Variance: " + Stats.Var(vec1.GetData()));
            
            Debug.Print("\n\nEND UNIT TESTS");
        }
    }
}
