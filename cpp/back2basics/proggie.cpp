#include <iostream>

using namespace std;

void SlowerLanguages(){
    string slower[] = {"Python", "Java", "C#", "JavaScript", "All above"};
    cout << "The languages above are slower:" << endl;
    for(const auto& i:slower){
        cout << i << endl;
    }
    
}

int main(){
    int EXIT_CODE = 0;
    cout << "Cpp is a very fast language!" << endl;
    SlowerLanguages();
    return EXIT_CODE;
}