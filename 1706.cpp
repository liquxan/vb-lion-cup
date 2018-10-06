#include <stdio.h>
#include <stdlib.h>


int main(int argc, char *argv[]) {
	int a[10]={2,40,300,200,100,90,20,50,60,5},b[10]={1,4,24,15,7,7,3,5,5,2},i,j,to,s[10],nu[10],x,k;
	scanf("%d",&x);
	for(i=0;i<10;i++){
		scanf("%d",&nu[i]);
	}
	for(i=0;i<10;i++){
		s[i]=a[i]/b[i];
	}
	for(i=0;i<10;i++){
		for(j=0;j<9;j++){
			if(s[j]>s[j+1]){
				k=s[j];
				s[j]=s[j+1];
				s[j+1]=k;
				k=nu[j];
				nu[j]=nu[j+1];
				nu[j+1]=k;
				k=a[j];
				a[j]=a[j+1];
				a[j+1]=k;
				k=b[j];
				b[j]=b[j+1];
				b[j+1]=k;
			}
		}
	}
	for(i=9;i>=0;i--){
		if(x>=b[i]&&nu[i]>0){
			to+=a[i];
			x-=b[i];
			nu[i]-=1;
			i++;
		}
	}
	printf("%d",to);
	return 0;
}
