import javax.swing.plaf.nimbus.State;
import java.sql.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        try {
            //Cargamos el driver correcto para nuestra aplicación
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //Realizamos la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=Futbol;user=sa;password=root;TrustServerCertificate=True;");

            Statement stmt = conn.createStatement();

            //Actividad 2
            /*
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
            */

            //Actividad 3
            //Muestra a todos los futbolistas de un equipo que pidas por pantalla
            System.out.println("Dame el código del equipo del que quieras saber los futbolistas: ");
            Scanner sc = new Scanner(System.in);
            String nombreEquipo = sc.nextLine();
            PreparedStatement pStmt = conn.prepareStatement("SELECT * FROM Futbolistas WHERE CodigoEquipo = ?");

            pStmt.setString(1, nombreEquipo);
            ResultSet resultados = pStmt.executeQuery();
            while (resultados.next()) {
                System.out.println("Nombre:" + resultados.getString("nombre"));
                System.out.println("Posicion:" + resultados.getString("posicion"));
                System.out.println("----------------------------------");
            }

            //Introduce a un futbolista en un equipo
            System.out.println("Dame el codigo del futbolista que quieras insertar: ");
            String codigoFutbolista = sc.nextLine();
            System.out.println("Dame el nombre del futbolista que quieras insertar: ");
            String nombreFutbolista = sc.nextLine();
            System.out.println("Dame el código del equipo en el que va a jugar: ");
            String codigoEquipo = sc.nextLine();
            System.out.println("Dame la posición de ese futbolista: ");
            String posicionFutbolista = sc.nextLine();
            pStmt = conn.prepareStatement("INSERT INTO Futbolistas (Codigo, Nombre, CodigoEquipo, Posicion) VALUES (?, ?, ?, ?)");

            pStmt.setString(1, codigoFutbolista);
            pStmt.setString(2, nombreFutbolista);
            pStmt.setString(3, codigoEquipo);
            pStmt.setString(4, posicionFutbolista);

            int registros = pStmt.executeUpdate();
            if (registros > 0) System.out.println("Se ha insertado un futbolista");

            //Actualiza la edad de un futbolista
            System.out.println("Dame el codigo del futbolista que quieras actualizar la edad: ");
            codigoFutbolista = sc.nextLine();
            System.out.println("Dame la edad actual: ");
            int edadFutbolista = sc.nextInt();
            pStmt = conn.prepareStatement("UPDATE Futbolistas SET Edad = ? WHERE Codigo = ?");

            pStmt.setInt(1, edadFutbolista);
            pStmt.setString(2, codigoFutbolista);

            registros = pStmt.executeUpdate();
            if (registros > 0) System.out.println("Se ha actualizado la edad de un futbolista");

            //Borra un futbolista
            System.out.println("Dame el codigo del futbolista que quieras borrar: ");
            codigoFutbolista = sc.nextLine();
            pStmt = conn.prepareStatement("DELETE Futbolistas WHERE Codigo = ?");

            pStmt.setString(1, codigoFutbolista);

            registros = pStmt.executeUpdate();
            if (registros > 0) System.out.println("Se ha borrado un futbolista");

        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}