SELECT * FROM proveedores;

INSERT INTO proveedores (Nombre, Contacto)
VALUES ('Margarita de León', '809-685-4747'),
('Rafael Rodríguez', '829-698-3225'),
('Carmen Mercado', '849-748-6996'),
('Zolia Maldonado', '829-748-5596'),
('Marcos López', '809-222-7896');

SELECT * FROM categorias;

INSERT INTO categorias (Nombre)
VALUES ('Papelería'), ('Electrónico'), ('Cosméticos'), ('Alimentos'), ('Limpieza'), ('Decoración');

SELECT * FROM productos;

INSERT INTO productos (Nombre, Precio, Stock, CategoriaId, ProveedorId)
VALUES ('Leche Evaporada (Rica)', 112.63, 5, 4, 3),
('Cloro (Maciel)', 56.39, 10, 5, 2),
('CornFlakes (Nestlé)', 80.52, 9, 4, 3),
('Detergente (Downie)', 78.94, 15, 5, 2),
('Hojas Blancas (PaperMate)', 3, 100, 1, 1),
('Laptop (Lenovo) i5 64GB', 21000, 5, 2, 4),
('Televisor (JVC) SmartTv 62p', 19000, 15, 2, 4),
('Lip oil (Rare Beauty)', 600, 25, 3, 5);