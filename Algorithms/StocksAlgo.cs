namespace Algorithms
{
    public class StocksAlgo
    {
        public int MaxProfit(int[] prices)
        {
            //two indices one in the beginning, i=0, j=1, pivot = arr[j] - arr[i] (should be greater than 0, if not i=1, j = i+1)
            // now traverse the array incrementally using second index
            // if (difference(arr[j],arr[i]) > pivot){
            //     Then pivot = arr[j] - arr[i];
            //    j++;
            // end of first iteration
            //   i++;
            //   j = i+1;
            // end of second iteration
            // return pivot
            var i = 0;
            var j = 1;
            var pivot = 0;
            while(i < prices.Length - 1)
            {
                while( j < prices.Length)
                {
                    if(prices[j] - prices[i] < 0)
                    {
                        i = j;
                        j = i + 1;
                        continue;
                    }
                    else
                    {
                        if(prices[j] - prices[i] > pivot)
                        {
                            pivot = prices[j] - prices[i];
                        }
                    }
                    j++;                  
                }
                i++;
                j = i + 1;                           
            }
            return pivot;
        }

    }
}
