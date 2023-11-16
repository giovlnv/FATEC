package pack;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

/**
 * Servlet implementation class ConversorMoedas
 */
public class ConversorMoedas extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ConversorMoedas() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		Double reis = Double.parseDouble(request.getParameter("reis"));
		Double crit = Double.parseDouble(request.getParameter("crit"));
		Double converte = reis * crit;
		PrintWriter saida = response.getWriter();
		saida.println("<html lang=\"PT-BR\"> <meta charset=\"utf-8\"> <body><h1>R$"+reis+" são: "+converte+" Kwanzas</h1><br><br><h2>A taxa de conversão é: " + crit+ " Kwanzas para cada 1 real</body></html>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
