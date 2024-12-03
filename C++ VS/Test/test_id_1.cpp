#include<iostream>
#include<math.h>

void enterArray(int array[], int n){
    for(int i = 0; i < n; i++){
        std::cout<<"enter element ["<<i+1<<"]: ";
        std::cin>>array[i];
    }
}

void displayArray(int array[], int n){
    for(int i = 0; i < n; i++){
        std::cout<<array[i]<<"  ";
    }
}

int sum(int array[], int n){
    int result = 0;

    for(int i = 1; i < n-1; i++) if(array[i] > array[i - 1] && array[i] > array[i + 1]) result += array[i];

    return result;

}

bool opposite(int array[], int n){
    int i = 0, j = n - 1;

    while( i < j){
        if(array[i] == array[j]){
            i++;
            j--;
        }
        else return false;
    }

    return true;
}

int maxElement(int array[], int n){
    int element = array[0];
    for(int i=1; i<n; i++){
        element = element < array[i] ? array[i] : element;
    }
    return element;
}

int minElement(int array[], int n){
    int element = array[0];
    for(int i=1; i<n; i++){
        element = element > array[i] ? array[i] : element;
    }
    return element;
}


void sort(int array[], int n){
    for(int i = 0; i < n - 1; i++){
        for(int j = i+1; j < n; j++){
            if(array[i] > array[j]){
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
bool primary(int n){
    if(n < 2) return false;
    else{
        for(int i=2; i <=  sqrt(n); i++){
            if(n % i == 0) return false;
        }

        return true;
    }
}

int countPrimary(int array[], int n){
    int count = 0;
    int arr[n];
    for(int i=0; i<n; i++){
        if(primary(array[i])){
            arr[count] = array[i];
            count++;
        }
    }
    sort(arr, count);
    displayArray(arr, count);
    return count;
}
int main()
{
    int n;
    int array[10000];
    do{
        std::cout<<"enter n: ";
        std::cin>>n;
    }while(n > 20 && n < 1);

    std::cout<<std::endl<<"section a: "<<std::endl;
    enterArray(array, n);
    displayArray(array, n);
    std::cout<<std::endl<<"section b: "<<sum(array, n);
    std::cout<<std::endl<<"section c: "<<(opposite(array, n) ? "Yes" : "No");
    std::cout<<std::endl<<"section d: "<<std::endl<<"- Max value: "<<maxElement(array, n)<<std::endl<<"- Min value: "<<minElement(array, n);
    std::cout<<std::endl<<"section e: "<<std::endl<<"- Number of primary: "<<countPrimary(array, n)<<std::endl;
    std::cout<<"- Primary: "; countPrimary(array, n);

    return 0;
}