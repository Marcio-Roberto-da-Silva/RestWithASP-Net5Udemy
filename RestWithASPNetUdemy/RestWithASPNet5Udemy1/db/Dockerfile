FROM mysql:5.7.22
EXPOSE 3306
COPY ./RestWithASPNet5Udemy1/db/migrations/ /home/database/
COPY ./RestWithASPNet5Udemy1/db/dataset/ /home/database/
COPY ./RestWithASPNet5Udemy1/ci/Init_database.sh.txt /docker-entrypoint-initdb.d/init_database.sh