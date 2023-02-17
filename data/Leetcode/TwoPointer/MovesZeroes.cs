namespace data.Leetcode.TwoPointer;

public class MovesZeroes
{
    //swab angka 0 ke belakang array
    public int[] main(int[] number)
    {
      int left = 0;
      int right = 1;
      while (right<number.Length)
      {
        Console.WriteLine("[{0}]", string.Join(", ", number));
       if (number[left] != 0)
        {
          right++;
          left++;
        }
       else if (number[right] == 0)
        {
          right++;
        }
       
        else
        {
          int temp = number[right];
          number[right] = number[left];
          number[left] = temp;
        }
      }

      return number;
    }
}

/*
 //mind map
 pointer kanan akan mencari element yang bukan 0
 pointer yang kiri mencari element yang 0
 kalo pointer yang kanan malah nemu 0 akan cari lagi
 kalo yang yang kiri dapat nilai 0 dan yang kanan dapet nilai yang bukan 0
 yang kanan akan di tukar ke yang kiri
 logic
 cek kalo pointer left gak nemu 0 maka langsung geser 2 pointer ke kanan
 cek kalo pointer kanan numu 0 maka right nya geser ke kanan
 kalo kedua kondisi itu gk terjadi berati left nemu 0 dan right gak nemu 0 -> disaat itulah proses swab terjadi
 {0,1,0,3,12} ->kondisi yang kiri adalah 0 dan kanan tidak 0 maka di swab nilainya
  ^ ^
  hasilnya
->{1,0,0,3,12} 
  //kalo number pointer ke 1 tidak sama dengan 0->geser 2 pointer nya ke kanan
*/