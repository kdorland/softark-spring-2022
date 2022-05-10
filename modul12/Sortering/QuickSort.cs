namespace Sortering;

public static class QuickSort {
	
	private static void Swap(int[] array, int k, int j) {
		int tmp = array[k];
		array[k] = array[j];
		array[j] = tmp;
	}
	
	private static void _quickSort(int[] array, int low, int high) {
		if (low < high) {
			int pivot = Partition(array, low, high);
			_quickSort(array, low, pivot - 1);
			_quickSort(array, pivot + 1, high);
		}
	}
	
	private static int Partition(int[] array, int low, int high) {
        // TODO: Implement!
        return -1;
    }
	
	public static void Sort(int[] array) {
        return; // TODO: remove return, use code below instead.
        //_quickSort(array, 0, array.Length - 1);
    }
}