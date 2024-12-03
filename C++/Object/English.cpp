#include<iostream>
#include<string>
#include<math.h>
#include<ctime>
#include<cstdlib>
using namespace std;
bool check_random(int x, int n){
    if(x>n) return false;
    else if(x<=0) return false;
    else return true;
}
int reset_random(int x, int n){
    if(x>n || x<=0) x = rand();
    return x; 
}
int main()
{
    srand(time(NULL));
    int random = rand(); 
    /*"Mean",
    "Generous",
    "Honest",
    "Dishonest",
    "Hard-Working",
    "Lazy",
    "Weak",
    "Strong",
    "Talkative",
    "Qucet",
    "Modest",
    "Arrogant",
    "Stupid",
    "Clever",
    "Shy",
    "Confident",
    "Funny",
    "Serious",
    "Polite",
    "Rude",
    "inpatient",
    "Patient",
    "Nice",
    "Nasty",
    "Horrible",
    "Roleplay",
    "Scenario",
    "Conversation",
    "Assistant",
    "Horrible",
    "Regular",
    "Move Into",
    "Terrible",
    "Cruise",
    "Horrible",
    "Exciting",
    "Tiring"*/
    /*"it ki nho nhen",
     "hao phong", 
    "chan that",
    "gia doi",
    "cham chi",
    "luoi bien",
    "yeu ot",
    "manh me",
    "hoat ngon",
    "im lang",
    "gian di",
    "kieu cang",
    "ngu ngoc",
    "thong minh",
    "mac co",
    "tu tin",
    "vui tinh",
    "nghiem tuc",
    "lich su",
    "tho lo",
    "khong kien nhan",
    "kien nhan",
    "tot bung",
    "xau xa",
    "te nan",
    "nhap vai",
    "kich ban",
    "cuoc hoi thoai",
    "tro ly",
    "te nan",
    "thuong xuyen",
    "chuyen vao"
    ,"kinh khung",
    "du thuyen",
    "te hai",
    "thu vi",
    "met moi"*/
    string str[]={"Mean","Generous","Honest","Dishonest","Hard-Working","Lazy","Weak","Strong","Talkative",
    "Qucet","Modest","Arrogant","Stupid","Clever","Shy","Confident","Funny","Serious","Polite","Rude",
    "inpatient","Patient","Nice","Nasty","Horrible","Roleplay","Scenario","Conversation","Assistant","Horrible",
    "Regular","Move Into","Terrible","Cruise","Horrible","Exciting","Tiring"};
    
    string result[]={"it ki nho nhen", "hao phong", "chan that","gia doi","cham chi","luoi bien","yeu ot",
    "manh me","hoat ngon","im lang","gian di","kieu cang","ngu ngoc","thong minh","mac co","tu tin","vui tinh",
    "nghiem tuc","lich su","tho lo","khong kien nhan","kien nhan","tot bung","xau xa","te nan","nhap vai", "kich ban",
    "cuoc hoi thoai","tro ly","te nan","thuong xuyen","chuyen vao","kinh khung","du thuyen","te hai","thu vi","met moi"};
    int respeat[]={0};
    int n = sizeof(str)/sizeof(string);  
    int score = 0;
    string s;
    int i = 0;
   
    for(;i<n;i++){
        while(!check_random(random,n)){
                random = reset_random(random,n);
        }
        system("cls");
        cout<<"   ["<<i+1<<"]"<<"\t\t Score: "<<score<<endl<<endl;
        cout<<str[random]<<" : ";
        respeat[random]++;

        fflush(stdin);
        getline(cin,s);
        if(s == result[random]){
            score++;
        }
        random = rand();
        system("cls");
    }

    for(int j=0;j<n;j++){
        if(respeat[j]==0){
            cout<<"   ["<<i+1<<"]"<<"\t\t Score: "<<score<<endl<<endl;
            cout<<str[j]<<" : ";
            respeat[j]++;
            fflush(stdin);
            getline(cin,s);
            i++;
            if(s == result[j]){
                score++;
            }
            system("cls");
        }
    }

    double m = score * 100 /(i+1);
    cout<<"\n\n\t\t\t\t The Right Answer Numbers : "<<score<<endl<<"\t\t\t\t\t\t\t"<<m<<"%"<<endl<<endl<<endl;
    return 0;
}