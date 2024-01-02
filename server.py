from http.server import HTTPServer,CGIHTTPRequestHandler
server_addres = ("",49001)
httpd = HTTPServer(server_addres,CGIHTTPRequestHandler)
httpd.serve_forever()