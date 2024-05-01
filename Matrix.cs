using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota3InARow
{
    public class Matrix
    {
        public int[,] ElementsMatrix;

        public int CountPoints { get => countPoints; set => countPoints = value; }
        public int CountVenga { get => countVenga; set => countVenga = value; }
        public int CountTechis { get => countTechis; set => countTechis = value; }
        public int CountEncha { get => countEncha; set => countEncha = value; }
        public int CountVrka { get => countVrka; set => countVrka = value; }
        public int CountZevs { get => countZevs; set => countZevs = value; }
        public int CountVoid { get => countVoid; set => countVoid = value; }
        public int CountSheiker { get => countSheiker; set => countSheiker = value; }

        public Matrix(int countRows)
        {
            CountPoints = 0;
            ElementsMatrix = new int[countRows, countRows];
            Mix();
        }

        public int this[int i, int j]
        {
            get { return ElementsMatrix[i, j]; }
            set { ElementsMatrix[i, j] = value; }
        }

        public void RandomizeMatrix()
        {
            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    ElementsMatrix[i, j] = getRandom.Next(1, ElementsMatrix.GetLength(0) + 1);
                }
            }
        }

        public bool IsIt3InARow()
        {
            return IsIt3InARow(ElementsMatrix);
        }

        public bool IsIt3InARow(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j > matrix.GetLength(1) - 3) continue;
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i, j + 2])
                    {
                        return true;
                    }
                }
            }

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (i > matrix.GetLength(0) - 3) continue;
                    if (matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 2, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Destroy3InARow()
        {
            int[,] helpMatrix = GetCopyMatrix();

            DestroyRows(ref helpMatrix);
            DestroyColumns(ref helpMatrix);
            AddPoints(helpMatrix);
            CountSkills(helpMatrix);
            DestroyMainMatrix(helpMatrix);
        }

        public void Destroy3InARow(int[,] helpMatrix)
        {
            DestroyRows(ref helpMatrix);
            DestroyColumns(ref helpMatrix);
            AddPoints(helpMatrix);
            CountSkills(helpMatrix);
            DestroyMainMatrix(helpMatrix);
        }

        public bool IsNulls()
        {
            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    if(this[i,j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void CountSkills(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        switch (this[i, j])
                        {
                            case 1:
                                countVenga++;
                                break;
                            case 5:
                                countTechis++;
                                break;
                            case 6:
                                countEncha++;
                                break;
                            case 7:
                                countVrka++;
                                break;
                            case 8:
                                countZevs++;
                                break;
                            case 9:
                                countVoid++;
                                break;
                            case 10:
                                countSheiker++;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void DestroyMainMatrix(int[,] helpMatrix)
        {
            for (int i = 0; i < helpMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < helpMatrix.GetLength(1); j++)
                {
                    if (helpMatrix[i, j] == 0)
                    {
                        ElementsMatrix[i, j] = 0;
                    }
                }
            }
        }

        private void DestroyRows(ref int[,] helpMatrix)
        {
            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    if (j > ElementsMatrix.GetLength(1) - 3) continue;
                    if (this[i, j] == this[i, j + 1] && this[i, j + 1] == this[i, j + 2])
                    {
                        helpMatrix[i, j] = 0;
                        helpMatrix[i, j + 1] = 0;
                        helpMatrix[i, j + 2] = 0;
                    }
                }
            }
        }

        private void DestroyColumns(ref int[,] helpMatrix)
        {
            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    if (i > ElementsMatrix.GetLength(0) - 3) continue;
                    if (this[i, j] == this[i + 1, j] && this[i, j] == this[i + 2, j])
                    {
                        helpMatrix[i, j] = 0;
                        helpMatrix[i + 1, j] = 0;
                        helpMatrix[i + 2, j] = 0;
                    }
                }
            }
        }

        public int[,] GetCopyMatrix()
        {
            int[,] result = new int[ElementsMatrix.GetLength(0), ElementsMatrix.GetLength(1)];

            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    result[i, j] = ElementsMatrix[i, j];
                }
            }
            return result;
        }

        public void SortMatrix()
        {
            int[,] helpMatrix = GetCopyMatrix();
            for (int z = 0; z < ElementsMatrix.GetLength(0) - 1; z++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(0); j++)
                {
                    for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
                    {
                        if (i == ElementsMatrix.GetLength(0) - 1) continue;
                        if (helpMatrix[i + 1, j] == 0)
                        {
                            Swap(ref helpMatrix[i, j], ref helpMatrix[i + 1, j]);
                        }
                    }
                }
            }
            ElementsMatrix = helpMatrix;
        }

        public void Swap(ref int first, ref int second)
        {
            int help = first;
            first = second;
            second = help;
        }

        public void AddPoints(int[,] matrix)
        {
            int countOfNull = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        countOfNull++;
                    }
                }
            }
            CountPoints += countOfNull * 20;
        }

        public void AddNewElements()
        {
            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    if (ElementsMatrix[i, j] == 0)
                    {
                        ElementsMatrix[i, j] = getRandom.Next(1, ElementsMatrix.GetLength(0) + 1);
                    }
                }
            }
        }

        public void Mix()
        {
            do
            {
                RandomizeMatrix();
            }
            while (IsIt3InARow(ElementsMatrix) == true);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < ElementsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ElementsMatrix.GetLength(1); j++)
                {
                    result += ElementsMatrix[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }

        private int countPoints;
        private int countVenga;
        private int countTechis;
        private int countEncha;
        private int countVrka;
        private int countZevs;
        private int countVoid;
        private int countSheiker;

        private static Random getRandom = new Random();
    }
}
