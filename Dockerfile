FROM python:alpine:3.18

RUN addgroup --gid 10001 --system nonroot \
  && adduser --uid 10000 --system --ingroup nonroot --home /home/nonroot nonroot

RUN apk add --no-cache tini 
ENTRYPOINT [ "/sbin/tini", "--" ]

RUN apk --no-cache add \
        build-base \
        ca-certificates \
        freetype \
        freetype-dev \
        openjpeg-dev \
        zlib-dev 

RUN pip install \ 
  pillow==2.8.0 \
  rainbowstream

USER nonroot 

CMD [ "rainbowstream" ]