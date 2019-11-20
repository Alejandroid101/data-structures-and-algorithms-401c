InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp

	  sample array = [8,4,23,42,16,15]


	  WE START BY DECLARING I AS ARR[1] (4), J IS ARR[I-1] (8) AND TEMP ARR[I](4).

	  In the first pass, we go in the while loop because both conditions are met.
	  we swap arr[0] and arr[1].

	  The next 2 numbers (23 and 42) are ignored at first because they are so far in increasing order, until
	  we arrive to arr[4] (16) which is smaller than the previous number, 42. 16 and 42 swap places, but then 16 is still
	  to the right of a number greater than itself, therefore the swap happens once again. Now it is in place.

	  The next pass will find 15, and the same will happen but now it will be swaped 3 times: It will be swaped with 
	  the number on the left because it is greater, until it passes 16 and then it will stay there.