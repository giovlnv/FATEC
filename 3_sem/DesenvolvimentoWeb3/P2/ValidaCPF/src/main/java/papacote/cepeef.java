package papacote;

import java.util.InputMismatchException;

public class cepeef {
	
	private String cpf;
	public boolean eCPF;
	
	cepeef(String a){
		this.cpf = a;
		this.eCPF = eCepeef(a);
	}
	
	public static boolean eCepeef(String a) {
		if(a.length()!=11 || a.equals("00000000000") || 
	            a.equals("11111111111") ||
	            a.equals("22222222222") || a.equals("33333333333") ||
	            a.equals("44444444444") || a.equals("55555555555") ||
	            a.equals("66666666666") || a.equals("77777777777") ||
	            a.equals("88888888888") || a.equals("99999999999") ) {
			return false;
		}
		char id1, id2;
		int soma, i, num, peso, r;
		try {
			soma=0; peso=10;
			for(i=0;i<9;i++) {
				num=(int)(a.charAt(i)-48);
				soma += (num*peso);
				peso--;
			}
			r=11-(soma%11);
			if((r==10)||(r==11)) {
				id1='0';
			}else {
				id1=(char)(r+48);
			}
			
			soma=0; peso=11;
			for(i=0;i<10;i++) {
				num=(int)(a.charAt(i)-48);
				soma += (num*peso);
				peso--;
			}
			r=11-(soma%11);
			if((r==10)||(r==11)) {
				id2='0';
			}else {
				id2=(char)(r+48);
			}
			
			if((id1==a.charAt(9)) && (id2==a.charAt(10))) {
				return true;
			}else {
				return false;
			}
		}catch(InputMismatchException e){
			return false;
		}
	}

}
