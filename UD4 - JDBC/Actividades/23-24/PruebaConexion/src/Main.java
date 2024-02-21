import javax.swing.plaf.nimbus.State;
import java.sql.*;

public class Main {
    public static void main(String[] args) {

        try {
            //Cargamos el driver correcto para nuestra aplicación
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //Realizamos la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=Futbol;user=sa;password=root;TrustServerCertificate=True;");

            Statement stmt = conn.createStatement();

            //Muestra todos los futbolistas que jueguen en el Real Madrid
            ResultSet resultados = stmt.executeQuery("SELECT * FROM Futbolistas WHERE CodigoEquipo = '#RMDRID'");
            while (resultados.next()) {
                System.out.println("Nombre:" + resultados.getString("nombre"));
                System.out.println("Posicion:" + resultados.getString("posicion"));
                System.out.println("----------------------------------");
            }

            //Introduce a Ramon en el RC Celta de Vigo
            int registrosAfectados = stmt.executeUpdate("INSERT INTO Futbolistas (Codigo, Nombre, CodigoEquipo, Posicion) VALUES ('RC0025', 'Ramón Ríos', '#RCELTA','Delantero')");
            if (registrosAfectados > 0) System.out.println("Se ha insertado un futbolista");

            //Actualiza a Ramos con la edad actual
            registrosAfectados = stmt.executeUpdate("UPDATE Futbolistas SET Edad = 37 WHERE Codigo = 'RM0005'");
            if (registrosAfectados > 0) System.out.println("Se ha actualizado un futbolista");

            //Borra a Messi del Barça
            registrosAfectados = stmt.executeUpdate("DELETE FROM Futbolistas WHERE Nombre = 'Mariano Díaz'");
            if (registrosAfectados > 0) System.out.println("Se ha borrado un futbolista");

        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}