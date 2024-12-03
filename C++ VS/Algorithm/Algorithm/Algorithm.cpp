#include<iostream>
#include<vector>
#include<list>
using namespace std;

void Meger_sort(vector<int> &arr) {
	int size = arr.size();
	if (size > 1) {

		int right = size;
		int mid = right / 2;

		vector<int> arr_right, arr_left;

		for (int i = 0; i < mid; i++) {
			arr_left.push_back(arr[i]);
		}
		for (int i = mid; i < right; i++) {
			arr_right.push_back(arr[i]);
		}

		int size_left = arr_left.size();
		int size_right = arr_right.size();

		Meger_sort(arr_left);
		Meger_sort(arr_right);

		int i = 0, j = 0, z = 0;

		while (!arr.empty()) {
			arr.pop_back();
		}

		while (i < size_left && j < size_right) {
			if (arr_left[i] < arr_right[j]) {
				arr.push_back(arr_left[i]);
				i++;
			}
			else {
				arr.push_back(arr_right[j]);
				j++;
			}
			z++;
		}
		while (i < size_left) {
			arr.push_back(arr_left[i]);
			i++;
		}
		while (j < size_right) {
			arr.push_back(arr_right[j]);
			j++;
		}

		while (!arr_left.empty()) {
			arr_left.pop_back();
		}

		while (!arr_right.empty()) {
			arr_right.pop_back();
		}
	}
}

void Bubble_sort(int arr) {
	
}
int main()
{
	int arr[] = {10,3,11,20,5,6,12,19,13,15,14,12,2,4,1,16,9,0,8,18,7,17};
	vector<int> vec;
	list<int> lis;
	int sizeArr = sizeof(arr) / sizeof(int);

	for (int x : arr) {
		lis.push_back(x);
	}

	int sizeVec = vec.size();

	for (list<int>::iterator it = lis.begin(); it != lis.end(); it++) {
		cout << *it <<" ";
	}
	Meger_sort(vec);

	for (int x : vec) {
		cout << x << " ";
	}

	return 0;
}