package pagodinho;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

/**
 * Servlet implementation class ServletHipotenusa
 */
public class ServletHipotenusa extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ServletHipotenusa() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		Double co = Double.parseDouble(request.getParameter("catetoOposto"));
		Double ca = Double.parseDouble(request.getParameter("catetoAdjacente"));
		Double hipQuadrado = (ca* ca) + (co * co);
		Double hip = Math.sqrt(hipQuadrado);
		
		PrintWriter saida = response.getWriter();
		saida.println("<html lang=\"PT-BR\"> <meta charset=\"utf-8\"> <body><h1>A hipotenusa dos catetos " + co + " e " + ca + " é: " + hip + "</h1></body></html>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
