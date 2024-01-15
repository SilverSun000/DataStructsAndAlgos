using System;

public class Sorting {
    public static int[] InsertionSort(int[] arr) {
        for (int i = 1; i < arr.Length; i++) {
            int key = arr[i];
            // Insert arr[i] into the sorted subarray arr[1: i-1]
            int j = i - 1;

            while(j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        return arr;
    }

    public static int SumArray(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) {
            sum += arr[i];
        }
        return sum;
    }

    public static int[] DecreasingInsertionSort(int[] arr) {
        for (int i = 1; i < arr.Length; i++) {
            int key = arr[i];
            // Insert arr[i] into the sorted subarray arr[1: i-1]
            int j = i - 1;

            while(j >= 0 && arr[j] < key) {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
        return arr;
    }

    public static int[] MergeSort(int[] arr) {
        if (arr.Length <= 1) {
        return arr;
    }

        int midPoint = arr.Length / 2;
        int[] leftHalf = new int[midPoint];
        int[] rightHalf = new int[arr.Length - midPoint];

        Array.Copy(arr, 0, leftHalf, 0, midPoint);
        Array.Copy(arr, midPoint, rightHalf, 0, arr.Length - midPoint);

        leftHalf = MergeSort(leftHalf);
        rightHalf = MergeSort(rightHalf);

        int[] result = Merge(leftHalf, rightHalf);

        return result;
    }

    public static int[] Merge(int[] left, int[] right) {
        int[] result = new int[left.Length + right.Length];
        int leftIndex = 0;
        int rightIndex = 0;
        int resultIndex = 0;

        // Compare elements and merge
        while (leftIndex < left.Length && rightIndex < right.Length) {
            if (left[leftIndex] <= right[rightIndex]) {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
            }
            else {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
            }
            resultIndex++;
        }

        //Copy remaining elements from left and right
        while (leftIndex < left.Length) {
            result[resultIndex] = left[leftIndex];
            leftIndex++;
            resultIndex++;
        }

        while (rightIndex < right.Length) {
            result[resultIndex] = right[rightIndex];
            rightIndex++;
            resultIndex++;
        }

        return result;
    }

    public static int[] BubbleSort(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j+1]) {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        return arr;
    }
}