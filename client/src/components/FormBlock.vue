<template>
  <div class="form">
    <slot name="content"></slot>
  </div>
</template>

<script>
export default {
  name: "FromBlock",
}
</script>

<style scoped lang="scss">
.form {
  padding: 20px;
  background-color: var(--black25);
  border-radius: 5px;
  box-shadow: 0 10px 25px rgb(0 0 0 / 5%), 0 20px 48px rgb(0 0 0 / 5%), 0 1px 4px rgb(0 0 0 / 10%);
}
</style>