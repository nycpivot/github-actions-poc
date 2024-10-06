FROM nginx:alpine
RUN rm -rf /usr/share/nginx/html/*
COPY src/web/jquery-3.7.1.min.js /usr/share/nginx/html
COPY src/web/index.html /usr/share/nginx/html