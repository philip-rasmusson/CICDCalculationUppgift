FROM node:14

WORKDIR /project

RUN npm ci

COPY . .

EXPOSE 8081

